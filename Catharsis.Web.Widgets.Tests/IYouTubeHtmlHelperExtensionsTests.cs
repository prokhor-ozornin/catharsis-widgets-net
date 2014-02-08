using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYouTubeHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IYouTubeHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYouTubeHtmlHelperExtensions.Video(IYouTubeHtmlHelper, Action{IYouTubeVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYouTubeHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YouTubeHtmlHelper().Video(null));

      Assert.True(new YouTubeHtmlHelper().Video(x => { }) == new YouTubeHtmlHelper().Video().ToHtmlString());
      Assert.True(new YouTubeHtmlHelper().Video(x => x.Id("id")) == new YouTubeHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYouTubeHtmlHelperExtensions.VideoLink(IYouTubeHtmlHelper, Action{IYouTubeVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYouTubeHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YouTubeHtmlHelper().VideoLink(null));

      Assert.True(new YouTubeHtmlHelper().VideoLink(x => { }) == new YouTubeHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new YouTubeHtmlHelper().VideoLink(x => x.Id("id")) == new YouTubeHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}