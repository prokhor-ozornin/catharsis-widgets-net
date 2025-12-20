using Newtonsoft.Json;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for class <see cref="TextWriter"/>.</para>
/// </summary>
/// <seealso cref="TextWriter"/>
public static class TextWriterExtensions
{
  /// <param name="writer"></param>
  extension(TextWriter writer)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="writer"/> is a <c>null</c> reference.</exception>
    public JsonTextWriter AsJson() => writer is not null ? new JsonTextWriter(writer) : throw new ArgumentNullException(nameof(writer));
  }
}