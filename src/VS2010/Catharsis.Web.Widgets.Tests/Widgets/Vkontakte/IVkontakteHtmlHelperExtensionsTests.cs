using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.AuthButton(IVkontakteHtmlHelper, Action{IVkontakteAuthButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void AuthButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.AuthButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().AuthButton(null));

      Assert.Equal(new VkontakteHtmlHelper().AuthButton().ToHtmlString(), new VkontakteHtmlHelper().AuthButton(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().AuthButton().Standard("url").ToHtmlString(), new VkontakteHtmlHelper().AuthButton(x => x.Standard("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Initialize(IVkontakteHtmlHelper, Action{IVkontakteInitializationWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Initialize(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Initialize(null));

      Assert.Equal(new VkontakteHtmlHelper().Initialize().ToHtmlString(), new VkontakteHtmlHelper().Initialize(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Initialize().ApiId("apiId").ToHtmlString(), new VkontakteHtmlHelper().Initialize(x => x.ApiId("apiId")));
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Comments(IVkontakteHtmlHelper, Action{IVkontakteCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Comments(null));

      Assert.Equal(new VkontakteHtmlHelper().Comments().ToHtmlString(), new VkontakteHtmlHelper().Comments(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Comments().Attach(VkontakteCommentsAttach.All).ToHtmlString(), new VkontakteHtmlHelper().Comments(x => x.Attach(VkontakteCommentsAttach.All)));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Community(IVkontakteHtmlHelper, Action{IVkontakteCommunityWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Community_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Community(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Community(null));

      Assert.Equal(new VkontakteHtmlHelper().Community().ToHtmlString(), new VkontakteHtmlHelper().Community(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Community().Account("account").ToHtmlString(), new VkontakteHtmlHelper().Community(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.LikeButton(IVkontakteHtmlHelper, Action{IVkontakteLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.LikeButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().LikeButton(null));

      Assert.Equal(new VkontakteHtmlHelper().LikeButton().ToHtmlString(), new VkontakteHtmlHelper().LikeButton(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().LikeButton().Text("text").ToHtmlString(), new VkontakteHtmlHelper().LikeButton(x => x.Text("text")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Poll(IVkontakteHtmlHelper, Action{IVkontaktePollWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Poll_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Poll(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Poll(null));

      Assert.Equal(new VkontakteHtmlHelper().Poll().ToHtmlString(), new VkontakteHtmlHelper().Poll(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Poll().Id("id").ToHtmlString(), new VkontakteHtmlHelper().Poll(x => x.Id("id")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Post(IVkontakteHtmlHelper, Action{IVkontaktePostWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Post_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Post(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Post(null));

      Assert.Equal(new VkontakteHtmlHelper().Post().ToHtmlString(), new VkontakteHtmlHelper().Post(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Post().Id("id").Owner("owner").Hash("hash").ToHtmlString(), new VkontakteHtmlHelper().Post(x => x.Id("id").Owner("owner").Hash("hash")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Recommendations(IVkontakteHtmlHelper, Action{IVkontakteRecommendationsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Recommendations_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Recommendations(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Recommendations(null));

      Assert.Equal(new VkontakteHtmlHelper().Recommendations().ToHtmlString(), new VkontakteHtmlHelper().Recommendations(x => { }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Subscription(IVkontakteHtmlHelper, Action{IVkontakteSubscriptionWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscription_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Subscription(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Subscription(null));

      Assert.Equal(new VkontakteHtmlHelper().Subscription().ToHtmlString(), new VkontakteHtmlHelper().Subscription(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Subscription().Account("account").ToHtmlString(), new VkontakteHtmlHelper().Subscription(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Video(IVkontakteHtmlHelper, Action{IVkontakteVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Video(null));

      Assert.Equal(new VkontakteHtmlHelper().Video().ToHtmlString(), new VkontakteHtmlHelper().Video(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Video().Id("id").ToHtmlString(), new VkontakteHtmlHelper().Video(x => x.Id("id")));
    }
  }
}