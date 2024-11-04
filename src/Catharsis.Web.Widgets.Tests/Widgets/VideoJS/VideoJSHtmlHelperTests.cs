using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VideoJSHtmlHelper"/>.</para>
  /// </summary>
  public sealed class VideoJSHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSHtmlHelper.Player()"/> method.</para>
    /// </summary>
    [Fact]
    public void Player_Method()
    {
      Assert.False(ReferenceEquals(this.html.VideoJS().Player(), this.html.VideoJS().Player()));
      Assert.True(this.html.VideoJS().Player() is VideoJSPlayerWidget);
    }
  }
}