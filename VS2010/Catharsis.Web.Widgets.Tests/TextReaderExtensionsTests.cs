using System;
using System.IO;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TextReaderExtensions"/>.</para>
  /// </summary>
  public sealed class TextReaderExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="TextReaderExtensions.Json(TextReader)"/> method.</para>
    /// </summary>
    [Fact]
    public void Json_Method()
    {
      Assert.Throws<ArgumentNullException>(() => TextReaderExtensions.Json(null));

      Assert.False(TextReader.Null.Json().Read());
      //throw new NotImplementedException();
    }
  }
}