using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Pinterest(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Pinterest_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Pinterest(null));

    widgets.Pinterest().Should().BeOfType<PinterestWidgetCreator>().And.BeSameAs(widgets.Pinterest());

    Assert.NotNull(html.Pinterest());
    Assert.True(ReferenceEquals(html.Pinterest(), html.Pinterest()));
  }
}