using Newtonsoft.Json;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for class <see cref="TextReader"/>.</para>
/// </summary>
/// <seealso cref="TextReader"/>
public static class TextReaderExtensions
{
  /// <param name="reader"></param>
  extension(TextReader reader)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="reader"/> is a <c>null</c> reference.</exception>
    public JsonTextReader AsJson() => reader is not null ? new JsonTextReader(reader) : throw new ArgumentNullException(nameof(reader));
  }
}