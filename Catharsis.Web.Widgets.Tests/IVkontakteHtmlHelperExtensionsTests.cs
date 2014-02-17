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
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Initialize(IVkontakteHtmlHelper, Action{IVkontakteInitWidget})"/> method.</para>
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
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Like(IVkontakteHtmlHelper, Action{IVkontakteLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Like(null));

      Assert.Equal(new VkontakteHtmlHelper().Like().ToHtmlString(), new VkontakteHtmlHelper().Like(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Like().Text("text").ToHtmlString(), new VkontakteHtmlHelper().Like(x => x.Text("text")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Subscribe(IVkontakteHtmlHelper, Action{IVkontakteSubscriptionWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribe_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Subscribe(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Subscribe(null));

      Assert.Equal(new VkontakteHtmlHelper().Subscribe().ToHtmlString(), new VkontakteHtmlHelper().Subscribe(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().Subscribe().Account("account").ToHtmlString(), new VkontakteHtmlHelper().Subscribe(x => x.Account("account")));
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

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.VideoLink(IVkontakteHtmlHelper, Action{IVkontakteVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().VideoLink(null));

      Assert.Equal(new VkontakteHtmlHelper().VideoLink().ToHtmlString(), new VkontakteHtmlHelper().VideoLink(x => { }));
      Assert.Equal(new VkontakteHtmlHelper().VideoLink().Id("id").ToHtmlString(), new VkontakteHtmlHelper().VideoLink(x => x.Id("id")));
    }
  }
}