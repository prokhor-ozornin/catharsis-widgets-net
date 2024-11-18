using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookWidgetsCreator"/>.</para>
/// </summary>
public sealed class FacebookWidgetsCreatorTests
{
  private readonly IFacebookWidgetsCreator widgets = Widgets.Web.Facebook();

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.False(ReferenceEquals(widgets.Initialize(), widgets.Initialize()));
    Assert.True(widgets.Initialize() is FacebookInitializationWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.ActivityFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void ActivityFeed_Method()
  {
    Assert.False(ReferenceEquals(widgets.ActivityFeed(), widgets.ActivityFeed()));
    Assert.True(widgets.ActivityFeed() is FacebookActivityFeedWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.RecommendationsFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void RecommendationsFeed_Method()
  {
    Assert.False(ReferenceEquals(widgets.RecommendationsFeed(), widgets.RecommendationsFeed()));
    Assert.True(widgets.RecommendationsFeed() is FacebookRecommendationsFeedWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgets.Comments(), widgets.Comments()));
    Assert.True(widgets.Comments() is FacebookCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FacePile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Facepile_Method()
  {
    Assert.False(ReferenceEquals(widgets.FacePile(), widgets.FacePile()));
    Assert.True(widgets.FacePile() is FacebookFacePileWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is FacebookFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is FacebookLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeBox()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeBox_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeBox(), widgets.LikeBox()));
    Assert.True(widgets.LikeBox() is FacebookLikeBoxWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.False(ReferenceEquals(widgets.Post(), widgets.Post()));
    Assert.True(widgets.Post() is FacebookPostWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.SendButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SendButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.SendButton(), widgets.SendButton()));
    Assert.True(widgets.SendButton() is FacebookSendButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is FacebookVideoWidget);
  }
}