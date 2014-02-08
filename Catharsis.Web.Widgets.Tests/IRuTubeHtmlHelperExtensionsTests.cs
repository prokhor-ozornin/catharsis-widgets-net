using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IRuTubeHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IRuTubeHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IRuTubeHtmlHelperExtensions.Video(IRuTubeHtmlHelper, Action{IRuTubeVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IRuTubeHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new RuTubeHtmlHelper().Video(null));

      Assert.True(new RuTubeHtmlHelper().Video(x => { }) == new RuTubeHtmlHelper().Video().ToHtmlString());
      Assert.True(new RuTubeHtmlHelper().Video(x => x.Id("id")) == new RuTubeHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IRuTubeHtmlHelperExtensions.VideoLink(IRuTubeHtmlHelper, Action{IRuTubeVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IRuTubeHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new RuTubeHtmlHelper().VideoLink(null));

      Assert.True(new RuTubeHtmlHelper().VideoLink(x => { }) == new RuTubeHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new RuTubeHtmlHelper().VideoLink(x => x.Id("id")) == new RuTubeHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}