using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YouTubeWidgetCreator"/>.</para>
/// </summary>
public sealed class YouTubeWidgetCreatorTests
{
  private readonly IYouTubeWidgetCreator widgets = Widgets.Web.YouTube();

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is YouTubeVideoWidget);
  }
}