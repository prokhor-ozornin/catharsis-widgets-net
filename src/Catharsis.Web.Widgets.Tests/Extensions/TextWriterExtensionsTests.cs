using Catharsis.Commons;
using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using Xunit;

namespace Catharsis.Web.Widgets.Tests.Extensions;

/// <summary>
///   <para>Tests set for class <see cref="TextWriterExtensions"/>.</para>
/// </summary>
public sealed class TextWriterExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TextWriterExtensions.AsJson(TextWriter)"/> method.</para>
  /// </summary>
  [Fact]
  public void AsJson_Method()
  {
    using (new AssertionScope())
    {
      Validate(TextWriter.Null);
      Validate(TextWriter.Synchronized(TextWriter.Null));
    }

    AssertionExtensions.Should(() => TextWriterExtensions.AsJson(null)).ThrowExactly<ArgumentNullException>().WithParameterName("writer");

    return;

    static void Validate(TextWriter writer)
    {
      using (writer)
      {
        writer.AsJson().Should().BeOfType<JsonTextWriter>();
      }
    }
  }
}