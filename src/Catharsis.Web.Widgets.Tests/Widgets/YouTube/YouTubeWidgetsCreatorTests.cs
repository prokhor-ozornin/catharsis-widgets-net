using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YouTubeWidgetsCreator"/>.</para>
/// </summary>
public sealed class YouTubeWidgetsCreatorTests : ClassTest<YouTubeWidgetsCreator>
{
  private readonly IYouTubeWidgetsCreator widgets = Widgets.Web.YouTube();

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is YouTubeVideoWidget);
  }
}