using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Initialize(IFacebookHtmlHelper, Action{IFacebookInitializationWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Initialize(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Initialize(null));

      Assert.Equal(new FacebookHtmlHelper().Initialize().ToHtmlString(), new FacebookHtmlHelper().Initialize(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Initialize().AppId("appId").ToHtmlString(), new FacebookHtmlHelper().Initialize(x => x.AppId("appId")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.ActivityFeed(IFacebookHtmlHelper, Action{IFacebookActivityFeedWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void ActivityFeed_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.ActivityFeed(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().ActivityFeed(null));

      Assert.Equal(new FacebookHtmlHelper().ActivityFeed().ToHtmlString(), new FacebookHtmlHelper().ActivityFeed(x => { }));
      Assert.Equal(new FacebookHtmlHelper().ActivityFeed().Domain("domain").ToHtmlString(), new FacebookHtmlHelper().ActivityFeed(x => x.Domain("domain")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.RecommendationsFeed(IFacebookHtmlHelper, Action{IFacebookRecommendationsFeedWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void RecommendationsFeed_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.RecommendationsFeed(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().RecommendationsFeed(null));

      Assert.Equal(new FacebookHtmlHelper().RecommendationsFeed().ToHtmlString(), new FacebookHtmlHelper().RecommendationsFeed(x => { }));
      Assert.Equal(new FacebookHtmlHelper().RecommendationsFeed().Domain("domain").ToHtmlString(), new FacebookHtmlHelper().RecommendationsFeed(x => x.Domain("domain")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Comments(IFacebookHtmlHelper, Action{IFacebookCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Comments(null));

      Assert.Equal(new FacebookHtmlHelper().Comments().ToHtmlString(), new FacebookHtmlHelper().Comments(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Comments().Url("url").ToHtmlString(), new FacebookHtmlHelper().Comments(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Facepile(IFacebookHtmlHelper, Action{IFacebookFacepileWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Facepile_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Facepile(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Facepile(null));

      Assert.Equal(new FacebookHtmlHelper().Facepile().ToHtmlString(), new FacebookHtmlHelper().Facepile(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Facepile().Url("url").ToHtmlString(), new FacebookHtmlHelper().Facepile(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.FollowButton(IFacebookHtmlHelper, Action{IFacebookFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.FollowButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().FollowButton(null));

      Assert.Equal(new FacebookHtmlHelper().FollowButton().ToHtmlString(), new FacebookHtmlHelper().FollowButton(x => { }));
      Assert.Equal(new FacebookHtmlHelper().FollowButton().Url("url").ToHtmlString(), new FacebookHtmlHelper().FollowButton(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.LikeButton(IFacebookHtmlHelper, Action{IFacebookLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.LikeButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().LikeButton(null));

      Assert.Equal(new FacebookHtmlHelper().LikeButton().ToHtmlString(), new FacebookHtmlHelper().LikeButton(x => { }));
      Assert.Equal(new FacebookHtmlHelper().LikeButton().Url("url").ToHtmlString(), new FacebookHtmlHelper().LikeButton(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.LikeBox(IFacebookHtmlHelper, Action{IFacebookLikeBoxWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeBox_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.LikeBox(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().LikeBox(null));

      Assert.Equal(new FacebookHtmlHelper().LikeBox().ToHtmlString(), new FacebookHtmlHelper().LikeBox(x => { }));
      Assert.Equal(new FacebookHtmlHelper().LikeBox().Url("url").ToHtmlString(), new FacebookHtmlHelper().LikeBox(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Post(IFacebookHtmlHelper, Action{IFacebookPostWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Post_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Post(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Post(null));

      Assert.Equal(new FacebookHtmlHelper().Post().ToHtmlString(), new FacebookHtmlHelper().Post(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Post().Url("url").ToHtmlString(), new FacebookHtmlHelper().Post(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.SendButton(IFacebookHtmlHelper, Action{IFacebookSendButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Send_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.SendButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().SendButton(null));

      Assert.Equal(new FacebookHtmlHelper().SendButton().ToHtmlString(), new FacebookHtmlHelper().SendButton(x => { }));
      Assert.Equal(new FacebookHtmlHelper().SendButton().Url("url").ToHtmlString(), new FacebookHtmlHelper().SendButton(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Video(IFacebookHtmlHelper, Action{IFacebookVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Video(null));

      Assert.Equal(new FacebookHtmlHelper().Video().ToHtmlString(), new FacebookHtmlHelper().Video(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Video().Id("id").ToHtmlString(), new FacebookHtmlHelper().Video(x => x.Id("id")));
    }
  }
}