using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VideoJsWidgetCreator"/>.</para>
/// </summary>
public sealed class VideoJsWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJsWidgetCreator.Player()"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Assert.False(ReferenceEquals(this.html.VideoJS().Player(), this.html.VideoJS().Player()));
    Assert.True(this.html.VideoJS().Player() is VideoJSPlayerWidget);
  }
}