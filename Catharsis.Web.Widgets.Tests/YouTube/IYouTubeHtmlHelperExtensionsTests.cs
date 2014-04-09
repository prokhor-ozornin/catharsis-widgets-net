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

      Assert.Equal(new YouTubeHtmlHelper().Video().ToHtmlString(), new YouTubeHtmlHelper().Video(x => { }));
      Assert.Equal(new YouTubeHtmlHelper().Video().Id("id").ToHtmlString(), new YouTubeHtmlHelper().Video(x => x.Id("id")));
    }
  }
}