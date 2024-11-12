using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Test set for class <see cref="DisqusHtmlHelper"/>.</para>
  /// </summary>
  public sealed class DisqusHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="DisqusHtmlHelper.Comments()"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.False(ReferenceEquals(this.html.Disqus().Comments(), this.html.Disqus().Comments()));
      Assert.True(this.html.Disqus().Comments() is DisqusCommentsWidget);
    }
  }
}