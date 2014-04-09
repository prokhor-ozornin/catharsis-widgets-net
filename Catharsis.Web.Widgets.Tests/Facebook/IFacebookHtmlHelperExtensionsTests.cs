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
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Follow(IFacebookHtmlHelper, Action{IFacebookFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Follow(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Follow(null));

      Assert.Equal(new FacebookHtmlHelper().Follow().ToHtmlString(), new FacebookHtmlHelper().Follow(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Follow().Url("url").ToHtmlString(), new FacebookHtmlHelper().Follow(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Like(IFacebookHtmlHelper, Action{IFacebookLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Like(null));

      Assert.Equal(new FacebookHtmlHelper().Like().ToHtmlString(), new FacebookHtmlHelper().Like(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Like().Url("url").ToHtmlString(), new FacebookHtmlHelper().Like(x => x.Url("url")));
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
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Send(IFacebookHtmlHelper, Action{IFacebookSendButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Send_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Send(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Send(null));

      Assert.Equal(new FacebookHtmlHelper().Send().ToHtmlString(), new FacebookHtmlHelper().Send(x => { }));
      Assert.Equal(new FacebookHtmlHelper().Send().Url("url").ToHtmlString(), new FacebookHtmlHelper().Send(x => x.Url("url")));
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