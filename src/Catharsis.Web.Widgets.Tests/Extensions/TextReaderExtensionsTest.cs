using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TextReaderExtensions"/>.</para>
/// </summary>
public sealed class TextReaderExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderExtensions.AsJson(TextReader)"/> method.</para>
  /// </summary>
  [Fact]
  public void AsJson_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextReaderExtensions.AsJson(null)).ThrowExactly<ArgumentNullException>().WithParameterName("reader");

      new[] { TextReader.Null, TextReader.Synchronized(TextReader.Null) }.ForEach(Test);
    }

    return;
    
    static void Test(TextReader reader)
    {
      using (reader)
      {
        reader.AsJson().Should().BeOfType<JsonTextReader>();
      }
    }
  }
}