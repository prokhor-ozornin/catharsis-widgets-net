using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITwitterHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ITwitterHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterHtmlHelperExtensions.FollowButton(ITwitterHtmlHelper, Action{ITwitterFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterHtmlHelperExtensions.FollowButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().FollowButton(null));

      Assert.Equal(new TwitterHtmlHelper().FollowButton().ToHtmlString(), new TwitterHtmlHelper().FollowButton(x => { }));
      Assert.Equal(new TwitterHtmlHelper().FollowButton().Account("account").ToHtmlString(), new TwitterHtmlHelper().FollowButton(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterHtmlHelperExtensions.TweetButton(ITwitterHtmlHelper, Action{ITwitterTweetButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void TweetButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterHtmlHelperExtensions.TweetButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().TweetButton(null));

      Assert.Equal(new TwitterHtmlHelper().TweetButton().ToHtmlString(), new TwitterHtmlHelper().TweetButton(x => { }));
      Assert.Equal(new TwitterHtmlHelper().TweetButton().Text("text").ToHtmlString(), new TwitterHtmlHelper().TweetButton(x => x.Text("text")));
    }
  }
}