using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVimeoHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IVimeoHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVimeoHtmlHelperExtensions.Video(IVimeoHtmlHelper, Action{IVimeoVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVimeoHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VimeoHtmlHelper().Video(null));

      Assert.Equal(new VimeoHtmlHelper().Video().ToHtmlString(), new VimeoHtmlHelper().Video(x => { }));
      Assert.Equal(new VimeoHtmlHelper().Video().Id("id").ToHtmlString(), new VimeoHtmlHelper().Video(x => x.Id("id")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVimeoHtmlHelperExtensions.VideoLink(IVimeoHtmlHelper, Action{IVimeoVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVimeoHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VimeoHtmlHelper().VideoLink(null));

      Assert.Equal(new VimeoHtmlHelper().VideoLink().ToHtmlString(), new VimeoHtmlHelper().VideoLink(x => { }));
      Assert.Equal(new VimeoHtmlHelper().VideoLink().Id("id").ToHtmlString(), new VimeoHtmlHelper().VideoLink(x => x.Id("id")));
    }
  }
}