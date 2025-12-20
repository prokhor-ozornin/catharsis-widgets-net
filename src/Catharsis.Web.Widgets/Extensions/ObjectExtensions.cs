using Newtonsoft.Json;

namespace Catharsis.Web.Widgets.Extensions;

/// <summary>
///   <para>Set of extension methods for class <see cref="object"/>.</para>
/// </summary>
/// <seealso cref="object"/>
public static class ObjectExtensions
{
  /// <param name="subject"></param>
  extension(object subject)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="subject"/> is a <c>null</c> reference.</exception>
    public string Json() => subject is not null
      ? JsonConvert.SerializeObject(subject,
                                    new JsonSerializerSettings
                                    {
                                      Formatting = Formatting.None,
                                      DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                                      DefaultValueHandling = DefaultValueHandling.Ignore,
                                      ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                                    })
      : throw new ArgumentNullException(nameof(subject));
  }
}