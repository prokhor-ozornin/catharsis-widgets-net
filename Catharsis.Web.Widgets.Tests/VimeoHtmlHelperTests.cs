using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VimeoHtmlHelper"/>.</para>
  /// </summary>
  public sealed class VimeoHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vimeo().Video(), this.html.Vimeo().Video()));
      Assert.True(this.html.Vimeo().Video() is VimeoVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoHtmlHelper.VideoLink()"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vimeo().VideoLink(), this.html.Vimeo().VideoLink()));
      Assert.True(this.html.Vimeo().VideoLink() is VimeoVideoLinkWidget);
    }
  }
}