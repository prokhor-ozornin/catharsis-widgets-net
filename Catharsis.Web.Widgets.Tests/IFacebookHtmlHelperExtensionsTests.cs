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
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Initialize(IFacebookHtmlHelper, Action{IFacebookInitWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Initialize(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Initialize(null));

      Assert.True(new FacebookHtmlHelper().Initialize(x => { }) == new FacebookHtmlHelper().Initialize().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Initialize(x => x.AppId("appId")) == new FacebookHtmlHelper().Initialize().AppId("appId").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.ActivityFeed(IFacebookHtmlHelper, Action{IFacebookActivityFeedWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void ActivityFeed_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.ActivityFeed(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().ActivityFeed(null));

      Assert.True(new FacebookHtmlHelper().ActivityFeed(x => { }) == new FacebookHtmlHelper().ActivityFeed().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().ActivityFeed(x => x.Domain("domain")) == new FacebookHtmlHelper().ActivityFeed().Domain("domain").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.RecommendationsFeed(IFacebookHtmlHelper, Action{IFacebookRecommendationsFeedWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void RecommendationsFeed_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.RecommendationsFeed(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().RecommendationsFeed(null));

      Assert.True(new FacebookHtmlHelper().RecommendationsFeed(x => { }) == new FacebookHtmlHelper().RecommendationsFeed().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().RecommendationsFeed(x => x.Domain("domain")) == new FacebookHtmlHelper().RecommendationsFeed().Domain("domain").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Comments(IFacebookHtmlHelper, Action{IFacebookCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Comments(null));

      Assert.True(new FacebookHtmlHelper().Comments(x => { }) == new FacebookHtmlHelper().Comments().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Comments(x => x.Url("url")) == new FacebookHtmlHelper().Comments().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Facepile(IFacebookHtmlHelper, Action{IFacebookFacepileWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Facepile_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Facepile(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Facepile(null));

      Assert.True(new FacebookHtmlHelper().Facepile(x => { }) == new FacebookHtmlHelper().Facepile().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Facepile(x => x.Url("url")) == new FacebookHtmlHelper().Facepile().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Follow(IFacebookHtmlHelper, Action{IFacebookFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Follow(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Follow(null));

      Assert.True(new FacebookHtmlHelper().Follow(x => { }) == new FacebookHtmlHelper().Follow().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Follow(x => x.Url("url")) == new FacebookHtmlHelper().Follow().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Like(IFacebookHtmlHelper, Action{IFacebookLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Like(null));

      Assert.True(new FacebookHtmlHelper().Like(x => { }) == new FacebookHtmlHelper().Like().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Like(x => x.Url("url")) == new FacebookHtmlHelper().Like().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.LikeBox(IFacebookHtmlHelper, Action{IFacebookLikeBoxWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeBox_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.LikeBox(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().LikeBox(null));

      Assert.True(new FacebookHtmlHelper().LikeBox(x => { }) == new FacebookHtmlHelper().LikeBox().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().LikeBox(x => x.Url("url")) == new FacebookHtmlHelper().LikeBox().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Post(IFacebookHtmlHelper, Action{IFacebookPostWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Post_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Post(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Post(null));

      Assert.True(new FacebookHtmlHelper().Post(x => { }) == new FacebookHtmlHelper().Post().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Post(x => x.Url("url")) == new FacebookHtmlHelper().Post().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Send(IFacebookHtmlHelper, Action{IFacebookSendButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Send_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Send(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Send(null));

      Assert.True(new FacebookHtmlHelper().Send(x => { }) == new FacebookHtmlHelper().Send().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Send(x => x.Url("url")) == new FacebookHtmlHelper().Send().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Video(IFacebookHtmlHelper, Action{IFacebookVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Video(null));

      Assert.True(new FacebookHtmlHelper().Video(x => { }) == new FacebookHtmlHelper().Video().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Video(x => x.Id("id")) == new FacebookHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.VideoLink(IFacebookHtmlHelper, Action{IFacebookVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().VideoLink(null));

      Assert.True(new FacebookHtmlHelper().VideoLink(x => { }) == new FacebookHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().VideoLink(x => x.Id("id")) == new FacebookHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}