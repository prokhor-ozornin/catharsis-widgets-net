using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Test set for class <see cref="DisqusWidgetsCreator"/>.</para>
/// </summary>
public sealed class DisqusWidgetsCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(this.html.Disqus().Comments(), this.html.Disqus().Comments()));
    Assert.True(this.html.Disqus().Comments() is DisqusCommentsWidget);
  }
}