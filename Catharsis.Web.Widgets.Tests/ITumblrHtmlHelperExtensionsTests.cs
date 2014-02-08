using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITumblrHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ITumblrHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrHtmlHelperExtensions.Follow(ITumblrHtmlHelper, Action{ITumblrFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrHtmlHelperExtensions.Follow(null, widget => {}));
      Assert.Throws<ArgumentNullException>(() => new TumblrHtmlHelper().Follow(null));

      Assert.True(new TumblrHtmlHelper().Follow(x => { }) == new TumblrHtmlHelper().Follow().ToHtmlString());
      Assert.True(new TumblrHtmlHelper().Follow(x => x.Account("account")) == new TumblrHtmlHelper().Follow().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrHtmlHelperExtensions.Share(ITumblrHtmlHelper, Action{ITumblrShareButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrHtmlHelperExtensions.Share(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TumblrHtmlHelper().Share(null));

      Assert.True(new TumblrHtmlHelper().Share(x => { }) == new TumblrHtmlHelper().Share().ToHtmlString());
      Assert.True(new TumblrHtmlHelper().Share(x => x.Type(TumblrShareButtonType.First)) == new TumblrHtmlHelper().Share().Type(TumblrShareButtonType.First).ToHtmlString());
    }
  }
}