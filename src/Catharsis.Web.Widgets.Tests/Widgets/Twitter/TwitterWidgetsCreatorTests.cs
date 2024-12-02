using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterWidgetsCreator"/>.</para>
/// </summary>
public sealed class TwitterWidgetsCreatorTests : ClassTest<TwitterWidgetsCreator>
{
  private readonly ITwitterWidgetsCreator widgets = Widgets.Web.Twitter();

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Follow_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is TwitterFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.TweetButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Tweet_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetsCreator().TweetButton(null));

    Assert.False(ReferenceEquals(widgets.TweetButton(), widgets.TweetButton()));
    Assert.True(widgets.TweetButton() is TwitterTweetButtonWidget);
  }
}