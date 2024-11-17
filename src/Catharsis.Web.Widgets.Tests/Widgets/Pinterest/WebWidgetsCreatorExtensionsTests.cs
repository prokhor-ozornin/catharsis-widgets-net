using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Pinterest(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Pinterest_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Pinterest(null));

    Assert.NotNull(html.Pinterest());
    Assert.True(ReferenceEquals(html.Pinterest(), html.Pinterest()));
  }
}