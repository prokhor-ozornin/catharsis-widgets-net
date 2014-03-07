using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="RuTubeHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="RuTubeHtmlHelper"/>
  public sealed class RuTubeHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.RuTube().Video(), this.html.RuTube().Video()));
      Assert.True(this.html.RuTube().Video() is RuTubeVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeHtmlHelper.VideoLink()"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.RuTube().VideoLink(), this.html.RuTube().VideoLink()));
      Assert.True(this.html.RuTube().VideoLink() is RuTubeVideoLinkWidget);
    }
  }
}