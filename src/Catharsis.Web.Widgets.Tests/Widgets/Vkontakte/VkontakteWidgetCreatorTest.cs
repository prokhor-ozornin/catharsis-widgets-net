using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteWidgetsCreator"/>.</para>
/// </summary>
public sealed class VkontakteWidgetsCreatorTest : UnitTest
{
  private IVkontakteWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Vkontakte();

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
    Widgets.Comments().Should().BeOfType<VkontakteCommentsWidget>().And.NotBeSameAs(Widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Community()"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Widgets.Community().Should().BeOfType<VkontakteCommunityWidget>().And.NotBeSameAs(Widgets.Community());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Widgets.Initialize().Should().BeOfType<VkontakteInitializationWidget>().And.NotBeSameAs(Widgets.Initialize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Widgets.LikeButton().Should().BeOfType<VkontakteLikeButtonWidget>().And.NotBeSameAs(Widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Poll()"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Widgets.Poll().Should().BeOfType<VkontaktePollWidget>().And.NotBeSameAs(Widgets.Poll());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Widgets.Post().Should().BeOfType<VkontaktePostWidget>().And.NotBeSameAs(Widgets.Post());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Recommendations()"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Widgets.Recommendations().Should().BeOfType<VkontakteRecommendationsWidget>().And.NotBeSameAs(Widgets.Recommendations());
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
    Widgets.Subscription().Should().BeOfType<VkontakteSubscriptionWidget>().And.NotBeSameAs(Widgets.Subscription());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<VkontakteVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}