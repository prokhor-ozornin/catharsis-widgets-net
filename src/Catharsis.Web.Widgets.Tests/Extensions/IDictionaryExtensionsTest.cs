using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IDictionaryExtensions"/>.</para>
/// </summary>
public sealed class IDictionaryExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDictionaryExtensions.ToUrlQuery(IDictionary{string, object})"/> method.</para>
  /// </summary>
  [Fact]
  public void ToUrlQuery_Method()
  {
    AssertionExtensions.Should(() => IDictionaryExtensions.ToUrlQuery(null)).ThrowExactly<ArgumentNullException>().WithParameterName("dictionary");

    throw new NotImplementedException();
  }
}