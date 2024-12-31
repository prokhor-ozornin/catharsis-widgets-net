using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IDictionaryExtensions"/>.</para>
/// </summary>
public sealed class IDictionaryExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDictionaryExtensions.ToUrlQuery(IDictionary{string, object})"/> method.</para>
  /// </summary>
  [Fact]
  public void ToUrlQuery_Method()
  {
    AssertionExtensions.Should(() => IDictionaryExtensions.ToUrlQuery(null)).ThrowExactly<ArgumentNullException>().WithParameterName("dictionary");

    Assert.Equal(string.Empty, new Dictionary<string, object>().ToUrlQuery());
    Assert.Equal("name=value", new Dictionary<string, object> { { "name", "value" } }.ToUrlQuery());
    Assert.Equal("first=1&second=2", new Dictionary<string, object> { { "first", 1 }, { "second", 2 } }.ToUrlQuery());
  }
}