using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="TwitterWidgetCreator"/>.</para>
/// </summary>
public sealed class TwitterWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Follow_Method()
  {
    Assert.False(ReferenceEquals(this.html.Twitter().FollowButton(), this.html.Twitter().FollowButton()));
    Assert.True(this.html.Twitter().FollowButton() is TwitterFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetCreator.TweetButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Tweet_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetCreator().TweetButton(null));

    Assert.False(ReferenceEquals(this.html.Twitter().TweetButton(), this.html.Twitter().TweetButton()));
    Assert.True(this.html.Twitter().TweetButton() is TwitterTweetButtonWidget);
  }
}