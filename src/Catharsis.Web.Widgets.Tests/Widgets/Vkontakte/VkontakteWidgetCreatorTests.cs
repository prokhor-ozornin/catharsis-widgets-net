using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteWidgetsCreator"/>.</para>
/// </summary>
public sealed class VkontakteWidgetsCreatorTests : ClassTest<VkontakteWidgetsCreator>
{
  private readonly IVkontakteWidgetsCreator widgets = Widgets.Web.Vkontakte();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IVkontakteWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.AuthButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void AuthButton_Method()
  {
    widgets.AuthButton().Should().BeOfType<VkontakteAuthButtonWidget>().And.NotBeSameAs(widgets.AuthButton());
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    widgets.Comments().Should().BeOfType<VkontakteCommentsWidget>().And.NotBeSameAs(widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Community()"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    widgets.Community().Should().BeOfType<VkontakteCommunityWidget>().And.NotBeSameAs(widgets.Community());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    widgets.Initialize().Should().BeOfType<VkontakteInitializationWidget>().And.NotBeSameAs(widgets.Initialize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    widgets.LikeButton().Should().BeOfType<VkontakteLikeButtonWidget>().And.NotBeSameAs(widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Poll()"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    widgets.Poll().Should().BeOfType<VkontaktePollWidget>().And.NotBeSameAs(widgets.Poll());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    widgets.Post().Should().BeOfType<VkontaktePostWidget>().And.NotBeSameAs(widgets.Post());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Recommendations()"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    widgets.Recommendations().Should().BeOfType<VkontakteRecommendationsWidget>().And.NotBeSameAs(widgets.Recommendations());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreator.ShareButton()"/> method.</para>
  /// </summary>
  /*[Fact]
  public void ShareButton_Method()
  {
    widgets.ShareButton().Should().BeOfType<VkontakteShareButtonWidget>().And.NotBeSameAs(widgets.ShareButton());
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Subscription()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    widgets.Subscription().Should().BeOfType<VkontakteSubscriptionWidget>().And.NotBeSameAs(widgets.Subscription());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<VkontakteVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}