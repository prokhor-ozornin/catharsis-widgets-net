using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class ITwitterWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterWidgetCreatorExtensions.FollowButton(ITwitterWidgetCreator, Action{ITwitterFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITwitterWidgetCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetCreator().FollowButton(null));

    Assert.Equal(new TwitterWidgetCreator().FollowButton().ToHtml(), new TwitterWidgetCreator().FollowButton(_ => { }));
    Assert.Equal(new TwitterWidgetCreator().FollowButton().Account("account").ToHtml(), new TwitterWidgetCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterWidgetCreatorExtensions.TweetButton(ITwitterWidgetCreator, Action{ITwitterTweetButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void TweetButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITwitterWidgetCreatorExtensions.TweetButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetCreator().TweetButton(null));

    Assert.Equal(new TwitterWidgetCreator().TweetButton().ToHtml(), new TwitterWidgetCreator().TweetButton(_ => { }));
    Assert.Equal(new TwitterWidgetCreator().TweetButton().Text("text").ToHtml(), new TwitterWidgetCreator().TweetButton(x => x.Text("text")));
  }
}