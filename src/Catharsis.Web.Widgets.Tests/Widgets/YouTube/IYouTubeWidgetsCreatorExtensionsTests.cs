using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYouTubeWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IYouTubeWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYouTubeWidgetsCreatorExtensions.Video(IYouTubeWidgetsCreator, Action{IYouTubeVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYouTubeWidgetsCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new YouTubeWidgetsCreator().Video(null));

    Assert.Equal(new YouTubeWidgetsCreator().Video().ToHtml(), new YouTubeWidgetsCreator().Video(_ => { }));
    Assert.Equal(new YouTubeWidgetsCreator().Video().Id("id").ToHtml(), new YouTubeWidgetsCreator().Video(x => x.Id("id")));
  }
}