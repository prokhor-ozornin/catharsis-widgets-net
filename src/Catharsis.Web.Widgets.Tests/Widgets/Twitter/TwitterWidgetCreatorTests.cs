using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="TwitterWidgetCreator"/>.</para>
/// </summary>
public sealed class TwitterWidgetCreatorTests : ClassTest<TwitterWidgetCreator>
{
  private readonly ITwitterWidgetCreator widgets = Widgets.Web.Twitter();

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Follow_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is TwitterFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetCreator.TweetButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Tweet_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetCreator().TweetButton(null));

    Assert.False(ReferenceEquals(widgets.TweetButton(), widgets.TweetButton()));
    Assert.True(widgets.TweetButton() is TwitterTweetButtonWidget);
  }
}