using System;
using System.IO;
using Catharsis.Commons;
using Newtonsoft.Json;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="TextWriter"/>.</para>
  /// </summary>
  /// <seealso cref="TextWriter"/>
  public static class TextWriterExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="writer"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="writer"/> is a <c>null</c> reference.</exception>
    public static JsonTextWriter Json(this TextWriter writer)
    {
      Assertion.NotNull(writer);

      return new JsonTextWriter(writer);
    }
  }
}