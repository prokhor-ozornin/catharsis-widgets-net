using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IFacebookWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.Initialize(IFacebookWidgetsCreator, Action{IFacebookInitializationWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.Initialize(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().Initialize(null));

    Assert.Equal(new FacebookWidgetsCreator().Initialize().ToHtml(), new FacebookWidgetsCreator().Initialize(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().Initialize().AppId("appId").ToHtml(), new FacebookWidgetsCreator().Initialize(x => x.AppId("appId")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.ActivityFeed(IFacebookWidgetsCreator, Action{IFacebookActivityFeedWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void ActivityFeed_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.ActivityFeed(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().ActivityFeed(null));

    Assert.Equal(new FacebookWidgetsCreator().ActivityFeed().ToHtml(), new FacebookWidgetsCreator().ActivityFeed(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().ActivityFeed().Domain("domain").ToHtml(), new FacebookWidgetsCreator().ActivityFeed(x => x.Domain("domain")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.RecommendationsFeed(IFacebookWidgetsCreator, Action{IFacebookRecommendationsFeedWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void RecommendationsFeed_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.RecommendationsFeed(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().RecommendationsFeed(null));

    Assert.Equal(new FacebookWidgetsCreator().RecommendationsFeed().ToHtml(), new FacebookWidgetsCreator().RecommendationsFeed(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().RecommendationsFeed().Domain("domain").ToHtml(), new FacebookWidgetsCreator().RecommendationsFeed(x => x.Domain("domain")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.Comments(IFacebookWidgetsCreator, Action{IFacebookCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.Comments(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().Comments(null));

    Assert.Equal(new FacebookWidgetsCreator().Comments().ToHtml(), new FacebookWidgetsCreator().Comments(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().Comments().Url("url").ToHtml(), new FacebookWidgetsCreator().Comments(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.FacePile"/> method.</para>
  /// </summary>
  [Fact]
  public void Facepile_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.FacePile(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().FacePile(null));

    Assert.Equal(new FacebookWidgetsCreator().Facepile().ToHtml(), new FacebookWidgetsCreator().FacePile(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().Facepile().Url("url").ToHtml(), new FacebookWidgetsCreator().FacePile(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.FollowButton(IFacebookWidgetsCreator, Action{IFacebookFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.FollowButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().FollowButton(null));

    Assert.Equal(new FacebookWidgetsCreator().FollowButton().ToHtml(), new FacebookWidgetsCreator().FollowButton(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().FollowButton().Url("url").ToHtml(), new FacebookWidgetsCreator().FollowButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.LikeButton(IFacebookWidgetsCreator, Action{IFacebookLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.LikeButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().LikeButton(null));

    Assert.Equal(new FacebookWidgetsCreator().LikeButton().ToHtml(), new FacebookWidgetsCreator().LikeButton(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().LikeButton().Url("url").ToHtml(), new FacebookWidgetsCreator().LikeButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.LikeBox(IFacebookWidgetsCreator, Action{IFacebookLikeBoxWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeBox_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.LikeBox(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().LikeBox(null));

    Assert.Equal(new FacebookWidgetsCreator().LikeBox().ToHtml(), new FacebookWidgetsCreator().LikeBox(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().LikeBox().Url("url").ToHtml(), new FacebookWidgetsCreator().LikeBox(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.Post(IFacebookWidgetsCreator, Action{IFacebookPostWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.Post(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().Post(null));

    Assert.Equal(new FacebookWidgetsCreator().Post().ToHtml(), new FacebookWidgetsCreator().Post(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().Post().Url("url").ToHtml(), new FacebookWidgetsCreator().Post(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.SendButton(IFacebookWidgetsCreator, Action{IFacebookSendButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Send_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.SendButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().SendButton(null));

    Assert.Equal(new FacebookWidgetsCreator().SendButton().ToHtml(), new FacebookWidgetsCreator().SendButton(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().SendButton().Url("url").ToHtml(), new FacebookWidgetsCreator().SendButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookWidgetsCreatorExtensions.Video(IFacebookWidgetsCreator, Action{IFacebookVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookWidgetsCreatorExtensions.Video(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new FacebookWidgetsCreator().Video(null));

    Assert.Equal(new FacebookWidgetsCreator().Video().ToHtml(), new FacebookWidgetsCreator().Video(x => { }));
    Assert.Equal(new FacebookWidgetsCreator().Video().Id("id").ToHtml(), new FacebookWidgetsCreator().Video(x => x.Id("id")));
  }
}