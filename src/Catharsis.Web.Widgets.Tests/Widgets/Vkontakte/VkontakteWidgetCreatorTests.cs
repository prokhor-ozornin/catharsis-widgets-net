using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteWidgetsCreator"/>.</para>
/// </summary>
public sealed class VkontakteWidgetsCreatorTests : ClassTest<VkontakteWidgetsCreator>
{
  private readonly IVkontakteWidgetsCreator widgetses = Widgets.Web.Vkontakte();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.AuthButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void AuthButton_Method()
  {
    Assert.False(ReferenceEquals(widgetses.AuthButton(), widgetses.AuthButton()));
    Assert.True(widgetses.AuthButton() is VkontakteAuthButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Video(), widgetses.Video()));
    Assert.True(widgetses.Video() is VkontakteVideoWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Initialize(), widgetses.Initialize()));
    Assert.True(widgetses.Initialize() is VkontakteInitializationWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Comments(), widgetses.Comments()));
    Assert.True(widgetses.Comments() is VkontakteCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Community()"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Community(), widgetses.Community()));
    Assert.True(widgetses.Community() is VkontakteCommunityWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Like_Method()
  {
    Assert.False(ReferenceEquals(widgetses.LikeButton(), widgetses.LikeButton()));
    Assert.True(widgetses.LikeButton() is VkontakteLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Poll()"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Poll(), widgetses.Poll()));
    Assert.True(widgetses.Poll() is VkontaktePollWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Post(), widgetses.Post()));
    Assert.True(widgetses.Post() is VkontaktePostWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Recommendations()"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Recommendations(), widgetses.Recommendations()));
    Assert.True(widgetses.Recommendations() is VkontakteRecommendationsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.ShareButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(widgetses.ShareButton(), widgetses.ShareButton()));
    Assert.True(widgetses.ShareButton() is VkontakteShareButtonWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Subscription()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Subscription(), widgetses.Subscription()));
    Assert.True(widgetses.Subscription() is VkontakteSubscriptionWidget);
  }
}