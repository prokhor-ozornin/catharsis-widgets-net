using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteWidgetCreator"/>.</para>
/// </summary>
public sealed class VkontakteWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.AuthButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void AuthButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().AuthButton(), this.html.Vkontakte().AuthButton()));
    Assert.True(this.html.Vkontakte().AuthButton() is VkontakteAuthButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Video(), this.html.Vkontakte().Video()));
    Assert.True(this.html.Vkontakte().Video() is VkontakteVideoWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Initialize(), this.html.Vkontakte().Initialize()));
    Assert.True(this.html.Vkontakte().Initialize() is VkontakteInitializationWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Comments(), this.html.Vkontakte().Comments()));
    Assert.True(this.html.Vkontakte().Comments() is VkontakteCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Community()"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Community(), this.html.Vkontakte().Community()));
    Assert.True(this.html.Vkontakte().Community() is VkontakteCommunityWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Like_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().LikeButton(), this.html.Vkontakte().LikeButton()));
    Assert.True(this.html.Vkontakte().LikeButton() is VkontakteLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Poll()"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Poll(), this.html.Vkontakte().Poll()));
    Assert.True(this.html.Vkontakte().Poll() is VkontaktePollWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Post(), this.html.Vkontakte().Post()));
    Assert.True(this.html.Vkontakte().Post() is VkontaktePostWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Recommendations()"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Recommendations(), this.html.Vkontakte().Recommendations()));
    Assert.True(this.html.Vkontakte().Recommendations() is VkontakteRecommendationsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteHtmlHelper.ShareButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().ShareButton(), this.html.Vkontakte().ShareButton()));
    Assert.True(this.html.Vkontakte().ShareButton() is VkontakteShareButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Subscription()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vkontakte().Subscription(), this.html.Vkontakte().Subscription()));
    Assert.True(this.html.Vkontakte().Subscription() is VkontakteSubscriptionWidget);
  }
}