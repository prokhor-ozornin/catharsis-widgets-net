using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteWidgetCreator"/>.</para>
/// </summary>
public sealed class VkontakteWidgetCreatorTests : ClassTest<VkontakteWidgetCreator>
{
  private readonly IVkontakteWidgetCreator widgets = Widgets.Web.Vkontakte();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.AuthButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void AuthButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.AuthButton(), widgets.AuthButton()));
    Assert.True(widgets.AuthButton() is VkontakteAuthButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is VkontakteVideoWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.False(ReferenceEquals(widgets.Initialize(), widgets.Initialize()));
    Assert.True(widgets.Initialize() is VkontakteInitializationWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgets.Comments(), widgets.Comments()));
    Assert.True(widgets.Comments() is VkontakteCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Community()"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Assert.False(ReferenceEquals(widgets.Community(), widgets.Community()));
    Assert.True(widgets.Community() is VkontakteCommunityWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Like_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is VkontakteLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Poll()"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Assert.False(ReferenceEquals(widgets.Poll(), widgets.Poll()));
    Assert.True(widgets.Poll() is VkontaktePollWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.False(ReferenceEquals(widgets.Post(), widgets.Post()));
    Assert.True(widgets.Post() is VkontaktePostWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Recommendations()"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Assert.False(ReferenceEquals(widgets.Recommendations(), widgets.Recommendations()));
    Assert.True(widgets.Recommendations() is VkontakteRecommendationsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.ShareButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.ShareButton(), widgets.ShareButton()));
    Assert.True(widgets.ShareButton() is VkontakteShareButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetCreator.Subscription()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    Assert.False(ReferenceEquals(widgets.Subscription(), widgets.Subscription()));
    Assert.True(widgets.Subscription() is VkontakteSubscriptionWidget);
  }
}