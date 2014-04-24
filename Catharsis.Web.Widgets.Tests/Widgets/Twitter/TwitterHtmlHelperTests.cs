using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TwitterHtmlHelper"/>.</para>
  /// </summary>
  public sealed class TwitterHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterHtmlHelper.FollowButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.False(ReferenceEquals(this.html.Twitter().FollowButton(), this.html.Twitter().FollowButton()));
      Assert.True(this.html.Twitter().FollowButton() is TwitterFollowButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterHtmlHelper.TweetButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void Tweet_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().TweetButton(null));

      Assert.False(ReferenceEquals(this.html.Twitter().TweetButton(), this.html.Twitter().TweetButton()));
      Assert.True(this.html.Twitter().TweetButton() is TwitterTweetButtonWidget);
    }
  }
}