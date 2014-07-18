using System;
using System.IO;
using Catharsis.Commons;
using Newtonsoft.Json;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="TextReader"/>.</para>
  /// </summary>
  /// <seealso cref="TextReader"/>
  public static class TextReaderExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="reader"/> is a <c>null</c> reference.</exception>
    public static JsonTextReader Json(this TextReader reader)
    {
      Assertion.NotNull(reader);

      return new JsonTextReader(reader);
    }
  }
}