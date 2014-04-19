using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVideoJSHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IVideoJSHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVideoJSHtmlHelperExtensions.Player(IVideoJSHtmlHelper, Action{IVideoJSPlayerWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Player_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVideoJSHtmlHelperExtensions.Player(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VideoJSHtmlHelper().Player(null));

      Assert.Equal(new VideoJSHtmlHelper().Player().ToHtmlString(), new VideoJSHtmlHelper().Player(x => { }));
      Assert.Equal(new VideoJSHtmlHelper().Player().Videos(new MediaSource("url", "contentType")).Width("width").Height("height").ToHtmlString(), new VideoJSHtmlHelper().Player(x => x.Videos(new MediaSource("url", "contentType")).Width("width").Height("height")));
    }
  }
}