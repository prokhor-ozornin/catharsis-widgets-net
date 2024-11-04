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
    ///   <para>Performs testing of <see cref="ITumblrHtmlHelperExtensions.FollowButton(ITumblrHtmlHelper, Action{ITumblrFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrHtmlHelperExtensions.FollowButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TumblrHtmlHelper().FollowButton(null));

      Assert.Equal(new TumblrHtmlHelper().FollowButton().ToHtmlString(), new TumblrHtmlHelper().FollowButton(x => { }));
      Assert.Equal(new TumblrHtmlHelper().FollowButton().Account("account").ToHtmlString(), new TumblrHtmlHelper().FollowButton(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrHtmlHelperExtensions.ShareButton(ITumblrHtmlHelper, Action{ITumblrShareButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrHtmlHelperExtensions.ShareButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TumblrHtmlHelper().ShareButton(null));

      Assert.Equal(new TumblrHtmlHelper().ShareButton().ToHtmlString(), new TumblrHtmlHelper().ShareButton(x => { }));
      Assert.Equal(new TumblrHtmlHelper().ShareButton().Type(TumblrShareButtonType.First).ToHtmlString(), new TumblrHtmlHelper().ShareButton(x => x.Type(TumblrShareButtonType.First)));
    }
  }
}