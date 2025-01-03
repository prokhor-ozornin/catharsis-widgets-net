using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookWidgetsCreator"/>.</para>
/// </summary>
public sealed class FacebookWidgetsCreatorTests : ClassTest<FacebookWidgetsCreator>
{
  private readonly IFacebookWidgetsCreator widgets = Widgets.Create.Facebook();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IFacebookWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    widgets.Initialize().Should().BeOfType<FacebookInitializationWidget>().And.NotBeSameAs(widgets.Initialize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.ActivityFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void ActivityFeed_Method()
  {
    widgets.ActivityFeed().Should().BeOfType<FacebookActivityFeedWidget>().And.NotBeSameAs(widgets.ActivityFeed());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.RecommendationsFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void RecommendationsFeed_Method()
  {
    widgets.RecommendationsFeed().Should().BeOfType<FacebookRecommendationsFeedWidget>().And.NotBeSameAs(widgets.RecommendationsFeed());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    widgets.Comments().Should().BeOfType<FacebookCommentsWidget>().And.NotBeSameAs(widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FacePile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Facepile_Method()
  {
    widgets.FacePile().Should().BeOfType<FacebookFacePileWidget>().And.NotBeSameAs(widgets.FacePile());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    widgets.FollowButton().Should().BeOfType<FacebookFollowButtonWidget>().And.NotBeSameAs(widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    widgets.LikeButton().Should().BeOfType<FacebookLikeButtonWidget>().And.NotBeSameAs(widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeBox()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeBox_Method()
  {
    widgets.LikeBox().Should().BeOfType<FacebookLikeBoxWidget>().And.NotBeSameAs(widgets.LikeBox());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    widgets.Post().Should().BeOfType<FacebookPostWidget>().And.NotBeSameAs(widgets.Post());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.SendButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SendButton_Method()
  {
    widgets.SendButton().Should().BeOfType<FacebookSendButtonWidget>().And.NotBeSameAs(widgets.SendButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<FacebookVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}