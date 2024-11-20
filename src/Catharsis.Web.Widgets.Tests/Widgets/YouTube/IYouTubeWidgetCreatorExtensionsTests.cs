using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IYouTubeWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class IYouTubeWidgetCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYouTubeWidgetCreatorExtensions.Video(IYouTubeWidgetCreator, Action{IYouTubeVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYouTubeWidgetCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new YouTubeWidgetCreator().Video(null));

    Assert.Equal(new YouTubeWidgetCreator().Video().ToHtml(), new YouTubeWidgetCreator().Video(_ => { }));
    Assert.Equal(new YouTubeWidgetCreator().Video().Id("id").ToHtml(), new YouTubeWidgetCreator().Video(x => x.Id("id")));
  }
}