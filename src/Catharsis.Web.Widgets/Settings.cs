using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public static class Settings
{
  public static IGlobalSettingsManager Global => new GlobalSettingsManager();
  public static ILocalSettingsManager Local => new LocalSettingsManager();
}

/// <summary>
///   <para></para>
/// </summary>
public interface ISettingsProvider
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  IEnumerable<string> Keys { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  ISettingsProvider Clear();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="name"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
  ISettingsProvider Remove(string name);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  object this[string name] { get; set; }
}

/// <summary>
///   <para></para>
/// </summary>
public interface IGlobalSettingsManager
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  ISettingsProvider Application { get; }
}

/// <summary>
///   <para></para>
/// </summary>
public interface ILocalSettingsManager
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  ISettingsProvider Cookies { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  ISettingsProvider Session { get; }
}

internal sealed class GlobalSettingsManager : IGlobalSettingsManager
{
  public ISettingsProvider Application => new ApplicationSettingsProvider();

  private sealed class ApplicationSettingsProvider : ISettingsProvider
  {
    public IEnumerable<string> Keys => HttpContext.Current.Application.AllKeys;

    public ISettingsProvider Clear()
    {
      HttpContext.Current.Application.Clear();
      return this;
    }

    public ISettingsProvider Remove(string name)
    {
      if (name is null) throw new ArgumentNullException(nameof(name));
      if (name.IsEmpty()) throw new ArgumentException(nameof(name));
      
      HttpContext.Current.Application.Remove(name);
      return this;
    }

    public object this[string name]
    {
      get => HttpContext.Current.Application[name];
      set { HttpContext.Current.Application.Set(name, value); }
    }
  }
}

internal sealed class LocalSettingsManager : ILocalSettingsManager
{
  public ISettingsProvider Cookies => new CookiesSettingsProvider();

  public ISettingsProvider Session => new SessionSettingsProvider();

  private sealed class SessionSettingsProvider : ISettingsProvider
  {
    public IEnumerable<string> Keys => HttpContext.Current.Session.Keys.Cast<string>();

    public ISettingsProvider Clear()
    {
      HttpContext.Current.Session.Clear();
      return this;
    }

    public ISettingsProvider Remove(string name)
    {
      if (name is null) throw new ArgumentNullException(nameof(name));
      if (name.IsEmpty()) throw new ArgumentException(nameof(name));

      HttpContext.Current.Session.Remove(name);
      return this;
    }

    public object this[string name]
    {
      get => HttpContext.Current.Session[name];
      set { HttpContext.Current.Session[name] = value; }
    }
  }

  private sealed class CookiesSettingsProvider : ISettingsProvider
  {
    public IEnumerable<string> Keys => HttpContext.Current.Response.Cookies.AllKeys;

    public ISettingsProvider Clear()
    {
      HttpContext.Current.Response.Cookies.Clear();
      return this;
    }

    public ISettingsProvider Remove(string name)
    {
      if (name is null) throw new ArgumentNullException(nameof(name));
      if (name.IsEmpty()) throw new ArgumentException(nameof(name));

      HttpContext.Current.Response.Cookies.Remove(name);
      return this;
    }

    public object this[string name]
    {
      get => HttpContext.Current.Response.Cookies[name];
      set { HttpContext.Current.Response.Cookies.Set(new HttpCookie(name, value.ToString())); }
    }
  }
}