using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteHtmlHelper"/>.</para>
  /// </summary>
  public sealed class VkontakteHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().Video(), this.html.Vkontakte().Video()));
      Assert.True(this.html.Vkontakte().Video() is VkontakteVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.Initialize()"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().Initialize(), this.html.Vkontakte().Initialize()));
      Assert.True(this.html.Vkontakte().Initialize() is VkontakteInitializationWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.Comments()"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().Comments(), this.html.Vkontakte().Comments()));
      Assert.True(this.html.Vkontakte().Comments() is VkontakteCommentsWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.Community()"/> method.</para>
    /// </summary>
    [Fact]
    public void Community_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().Community(), this.html.Vkontakte().Community()));
      Assert.True(this.html.Vkontakte().Community() is VkontakteCommunityWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.LikeButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().LikeButton(), this.html.Vkontakte().LikeButton()));
      Assert.True(this.html.Vkontakte().LikeButton() is VkontakteLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.Subscription()"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribe_Method()
    {
      Assert.False(ReferenceEquals(this.html.Vkontakte().Subscription(), this.html.Vkontakte().Subscription()));
      Assert.True(this.html.Vkontakte().Subscription() is VkontakteSubscriptionWidget);
    }
  }
}