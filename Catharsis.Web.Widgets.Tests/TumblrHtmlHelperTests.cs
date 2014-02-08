using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TumblrHtmlHelper"/></para>
  /// </summary>
  public sealed class TumblrHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrHtmlHelper.Follow()"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.False(ReferenceEquals(this.html.Tumblr().Follow(), this.html.Tumblr().Follow()));
      Assert.True(this.html.Tumblr().Follow() is TumblrFollowButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrHtmlHelper.Share()"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.False(ReferenceEquals(this.html.Tumblr().Share(), this.html.Tumblr().Share()));
      Assert.True(this.html.Tumblr().Share() is TumblrShareButtonWidget);
    }
  }
}