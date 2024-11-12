using System.Globalization;
using System.Web.WebPages;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for class <see cref="HttpRequest"/>.</para>
/// </summary>
/// <seealso cref="HttpRequest"/>
public static class HttpRequestExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="request"></param>
  /// <param name="name"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="request"/> or <paramref name="name"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
  public static object Parameter(this HttpRequest request, string name)
  {
    if (request is null) throw new ArgumentNullException(nameof(request));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    var nameLower = name.ToLowerInvariant();
    var nameUpper = name.ToUpperInvariant();

    var parameter = request.Params[name];
    if (parameter is null)
    {
      parameter = request.Params[nameLower];
    }
    if (parameter is null)
    {
      parameter = request.Params[nameUpper];
    }
    if (parameter is null)
    {
      parameter = request.Headers[name];
    }
    if (parameter is null)
    {
      parameter = request.Headers[nameLower];
    }
    if (parameter is null)
    {
      parameter = request.Headers[nameUpper];
    }
    if (parameter is null)
    {
      var cookie = request.Cookies[name];
      if (cookie is null)
      {
        cookie = request.Cookies[nameLower];
      }
      if (cookie is null)
      {
        cookie = request.Cookies[nameUpper];
      }
      if (cookie is not null)
      {
        parameter = cookie.Value;
      }
    }

    return parameter;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="request"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="request"/> is a <c>null</c> reference.</exception>
  public static CultureInfo Culture(this HttpRequest request) => request is not null ? CultureInfo.GetCultureInfo(request.Language()) : throw new ArgumentNullException(nameof(request));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="request"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="request"/> is a <c>null</c> reference.</exception>
  public static string Language(this HttpRequest request)
  {
    if (request is null) throw new ArgumentNullException(nameof(request));

    var language = request.Parameter("lang") ?? request.Parameter("language");

    if (language is null)
    {
      var acceptLanguage = request.Parameter("Accept-Language");
      if (acceptLanguage is not null)
      {
        language = acceptLanguage.ToString().Split(',').First();
      }
    }

    return language is not null ? language.ToString() : CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
  }
}