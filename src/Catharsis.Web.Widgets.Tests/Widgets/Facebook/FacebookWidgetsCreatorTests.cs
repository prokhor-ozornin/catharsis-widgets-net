using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookWidgetsCreator"/>.</para>
/// </summary>
public sealed class FacebookWidgetsCreatorTests : UnitTest
{
  private IFacebookWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Facebook();

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
    Widgets.Initialize().Should().BeOfType<FacebookInitializationWidget>().And.NotBeSameAs(Widgets.Initialize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.ActivityFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void ActivityFeed_Method()
  {
    Widgets.ActivityFeed().Should().BeOfType<FacebookActivityFeedWidget>().And.NotBeSameAs(Widgets.ActivityFeed());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.RecommendationsFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void RecommendationsFeed_Method()
  {
    Widgets.RecommendationsFeed().Should().BeOfType<FacebookRecommendationsFeedWidget>().And.NotBeSameAs(Widgets.RecommendationsFeed());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Widgets.Comments().Should().BeOfType<FacebookCommentsWidget>().And.NotBeSameAs(Widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FacePile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Facepile_Method()
  {
    Widgets.FacePile().Should().BeOfType<FacebookFacePileWidget>().And.NotBeSameAs(Widgets.FacePile());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Widgets.FollowButton().Should().BeOfType<FacebookFollowButtonWidget>().And.NotBeSameAs(Widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Widgets.LikeButton().Should().BeOfType<FacebookLikeButtonWidget>().And.NotBeSameAs(Widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeBox()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeBox_Method()
  {
    Widgets.LikeBox().Should().BeOfType<FacebookLikeBoxWidget>().And.NotBeSameAs(Widgets.LikeBox());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Widgets.Post().Should().BeOfType<FacebookPostWidget>().And.NotBeSameAs(Widgets.Post());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.SendButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SendButton_Method()
  {
    Widgets.SendButton().Should().BeOfType<FacebookSendButtonWidget>().And.NotBeSameAs(Widgets.SendButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<FacebookVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}