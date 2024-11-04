using System;
using Catharsis.Commons;
using Newtonsoft.Json;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="string"/>.</para>
  /// </summary>
  /// <seealso cref="string"/>
  public static class StringExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="subject"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="subject"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="subject"/> is <see cref="string.Empty"/> string.</exception>
    public static T Json<T>(this string subject)
    {
      Assertion.NotEmpty(subject);

      return JsonConvert.DeserializeObject<T>(subject, new JsonSerializerSettings { Formatting = Formatting.None, DateTimeZoneHandling = DateTimeZoneHandling.Utc, DefaultValueHandling = DefaultValueHandling.Ignore, PreserveReferencesHandling = PreserveReferencesHandling.Objects, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
    }
  }
}