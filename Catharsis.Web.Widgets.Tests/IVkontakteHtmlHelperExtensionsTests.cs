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

      Assert.True(new VkontakteHtmlHelper().Initialize(x => { }) == new VkontakteHtmlHelper().Initialize().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Initialize(x => x.ApiId("apiId")) == new VkontakteHtmlHelper().Initialize().ApiId("apiId").ToHtmlString());
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Comments(IVkontakteHtmlHelper, Action{IVkontakteCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Comments(null));

      Assert.True(new VkontakteHtmlHelper().Comments(x => { }) == new VkontakteHtmlHelper().Comments().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Comments(x => x.Attach(VkontakteCommentsAttach.All)) == new VkontakteHtmlHelper().Comments().Attach(VkontakteCommentsAttach.All).ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Community(IVkontakteHtmlHelper, Action{IVkontakteCommunityWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Community_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Community(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Community(null));

      Assert.True(new VkontakteHtmlHelper().Community(x => { }) == new VkontakteHtmlHelper().Community().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Community(x => x.Account("account")) == new VkontakteHtmlHelper().Community().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Like(IVkontakteHtmlHelper, Action{IVkontakteLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Like(null));

      Assert.True(new VkontakteHtmlHelper().Like(x => { }) == new VkontakteHtmlHelper().Like().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Like(x => x.Text("text")) == new VkontakteHtmlHelper().Like().Text("text").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Subscribe(IVkontakteHtmlHelper, Action{IVkontakteSubscriptionWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribe_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Subscribe(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Subscribe(null));

      Assert.True(new VkontakteHtmlHelper().Subscribe(x => { }) == new VkontakteHtmlHelper().Subscribe().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Subscribe(x => x.Account("account")) == new VkontakteHtmlHelper().Subscribe().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.Video(IVkontakteHtmlHelper, Action{IVkontakteVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().Video(null));

      Assert.True(new VkontakteHtmlHelper().Video(x => { }) == new VkontakteHtmlHelper().Video().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().Video(x => x.Id("id")) == new VkontakteHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteHtmlHelperExtensions.VideoLink(IVkontakteHtmlHelper, Action{IVkontakteVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new VkontakteHtmlHelper().VideoLink(null));

      Assert.True(new VkontakteHtmlHelper().VideoLink(x => { }) == new VkontakteHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new VkontakteHtmlHelper().VideoLink(x => x.Id("id")) == new VkontakteHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}