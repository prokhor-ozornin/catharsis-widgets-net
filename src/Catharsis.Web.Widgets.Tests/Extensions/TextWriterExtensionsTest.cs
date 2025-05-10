using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using Xunit;

namespace Catharsis.Web.Widgets.Tests.Extensions;

/// <summary>
///   <para>Tests set for class <see cref="TextWriterExtensions"/>.</para>
/// </summary>
public sealed class TextWriterExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TextWriterExtensions.AsJson(TextWriter)"/> method.</para>
  /// </summary>
  [Fact]
  public void AsJson_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextWriterExtensions.AsJson(null)).ThrowExactly<ArgumentNullException>().WithParameterName("writer");

      new[] { TextWriter.Null, TextWriter.Synchronized(TextWriter.Null) }.ForEach(Test);
    }

    return;

    static void Test(TextWriter writer)
    {
      using (writer)
      {
        writer.AsJson().Should().BeOfType<JsonTextWriter>();
      }
    }
  }
}