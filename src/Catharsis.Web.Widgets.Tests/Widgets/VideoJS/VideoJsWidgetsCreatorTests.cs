using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VideoJSWidgetsCreator"/>.</para>
/// </summary>
public sealed class VideoJsWidgetsCreatorTests : ClassTest<VideoJSWidgetsCreator>
{
  private readonly IVideoJSWidgetsCreator widgets = Widgets.Web.VideoJS();

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSWidgetsCreator.Player()"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Assert.False(ReferenceEquals(widgets.Player(), widgets.Player()));
    Assert.True(widgets.Player() is VideoJSPlayerWidget);
  }
}