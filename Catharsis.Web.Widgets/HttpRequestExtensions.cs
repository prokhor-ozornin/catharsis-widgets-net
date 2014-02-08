using System;
using System.Globalization;
using System.Linq;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="HttpRequest"/>.</para>
  ///   <seealso cref="HttpRequest"/>
  /// </summary>
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
      Assertion.NotNull(request);
      Assertion.NotEmpty(name);

      var nameLower = name.ToLowerInvariant();
      var nameUpper = name.ToUpperInvariant();

      var parameter = request.Params[name];
      if (parameter == null)
      {
        parameter = request.Params[nameLower];
      }
      if (parameter == null)
      {
        parameter = request.Params[nameUpper];
      }
      if (parameter == null)
      {
        parameter = request.Headers[name];
      }
      if (parameter == null)
      {
        parameter = request.Headers[nameLower];
      }
      if (parameter == null)
      {
        parameter = request.Headers[nameUpper];
      }
      if (parameter == null)
      {
        var cookie = request.Cookies[name];
        if (cookie == null)
        {
          cookie = request.Cookies[nameLower];
        }
        if (cookie == null)
        {
          cookie = request.Cookies[nameUpper];
        }
        if (cookie != null)
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
    public static CultureInfo Culture(this HttpRequest request)
    {
      Assertion.NotNull(request);

      return CultureInfo.GetCultureInfo(request.Language());
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="request"/> is a <c>null</c> reference.</exception>
    public static string Language(this HttpRequest request)
    {
      Assertion.NotNull(request);

      var language = request.Parameter("lang") ?? request.Parameter("language");
      if (language == null)
      {
        var acceptLanguage = request.Parameter("Accept-Language");
        if (acceptLanguage != null)
        {
          language = acceptLanguage.ToString().Split(',').First();
        }
      }
      return language != null ? language.ToString() : CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
    }
  }
}