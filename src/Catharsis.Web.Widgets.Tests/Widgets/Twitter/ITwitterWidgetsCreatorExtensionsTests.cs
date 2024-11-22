using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class ITwitterWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterWidgetsCreatorExtensions.FollowButton(ITwitterWidgetsCreator, Action{ITwitterFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITwitterWidgetsCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetsCreator().FollowButton(null));

    Assert.Equal(new TwitterWidgetsCreator().FollowButton().ToHtml(), new TwitterWidgetsCreator().FollowButton(_ => { }));
    Assert.Equal(new TwitterWidgetsCreator().FollowButton().Account("account").ToHtml(), new TwitterWidgetsCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterWidgetsCreatorExtensions.TweetButton(ITwitterWidgetsCreator, Action{ITwitterTweetButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void TweetButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITwitterWidgetsCreatorExtensions.TweetButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TwitterWidgetsCreator().TweetButton(null));

    Assert.Equal(new TwitterWidgetsCreator().TweetButton().ToHtml(), new TwitterWidgetsCreator().TweetButton(_ => { }));
    Assert.Equal(new TwitterWidgetsCreator().TweetButton().Text("text").ToHtml(), new TwitterWidgetsCreator().TweetButton(x => x.Text("text")));
  }
}