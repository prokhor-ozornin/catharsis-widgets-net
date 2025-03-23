using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Pinterest(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Pinterest_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Pinterest(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Pinterest().Should().BeOfType<PinterestWidgetsCreator>().And.BeSameAs(Widgets.Pinterest());
  }
}