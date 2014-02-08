using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YouTubeHtmlHelper"/>.</para>
  /// </summary>
  public sealed class YouTubeHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.YouTube().Video(), this.html.YouTube().Video()));
      Assert.True(this.html.YouTube().Video() is YouTubeVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeHtmlHelper.VideoLink()"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.YouTube().VideoLink(), this.html.YouTube().VideoLink()));
      Assert.True(this.html.YouTube().VideoLink() is YouTubeVideoLinkWidget);
    }
  }
}