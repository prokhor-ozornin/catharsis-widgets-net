using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="StringExtensions"/>.</para>
/// </summary>
public sealed class StringExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="StringExtensions.Json{T}(string)"/> method.</para>
  /// </summary>
  [Fact(Skip = "To be implemented")]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => StringExtensions.Json<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("subject");

    throw new NotImplementedException();
  }
}