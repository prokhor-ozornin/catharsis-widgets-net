using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="StringExtensions"/>.</para>
/// </summary>
/// <seealso cref="StringExtensions"/>
public sealed class StringExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="StringExtensions.Json{T}(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => StringExtensions.Json<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("subject");

    throw new NotImplementedException();
  }
}