using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TextReaderExtensions"/>.</para>
/// </summary>
public sealed class TextReaderExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderExtensions.Json(TextReader)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => TextReaderExtensions.Json(null)).ThrowExactly<ArgumentNullException>().WithParameterName("reader");

    TextReader.Null.Json().Read().Should().BeFalse();
    
    throw new NotImplementedException();
  }
}