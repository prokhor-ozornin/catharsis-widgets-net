using System;
using Catharsis.Commons;
using Newtonsoft.Json;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="object"/>.</para>
  ///   <seealso cref="object"/>
  /// </summary>
  public static class ObjectExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="subject"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="subject"/> is a <c>null</c> reference.</exception>
    public static string Json(this object subject)
    {
      Assertion.NotNull(subject);

      return JsonConvert.SerializeObject(subject, new JsonSerializerSettings { Formatting = Formatting.None, DateTimeZoneHandling = DateTimeZoneHandling.Utc, DefaultValueHandling = DefaultValueHandling.Ignore, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
    }
  }
}