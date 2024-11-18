using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VideoJsWidgetCreator"/>.</para>
/// </summary>
public sealed class VideoJsWidgetCreatorTests
{
  private readonly IVideoJSWidgetCreator widgets = Widgets.Web.VideoJS();

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJsWidgetCreator.Player()"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Assert.False(ReferenceEquals(widgets.Player(), widgets.Player()));
    Assert.True(widgets.Player() is VideoJSPlayerWidget);
  }
}