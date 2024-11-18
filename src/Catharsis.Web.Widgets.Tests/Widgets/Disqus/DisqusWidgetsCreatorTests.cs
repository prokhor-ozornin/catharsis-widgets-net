using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Test set for class <see cref="DisqusWidgetsCreator"/>.</para>
/// </summary>
public sealed class DisqusWidgetsCreatorTests
{
  private readonly IDisqusWidgetsCreator widgets = Widgets.Web.Disqus();

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgets.Comments(), widgets.Comments()));
    Assert.True(widgets.Comments() is DisqusCommentsWidget);
  }
}