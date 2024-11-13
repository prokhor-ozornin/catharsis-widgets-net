using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookWidgetsCreator"/>.</para>
/// </summary>
public sealed class FacebookWidgetsCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Initialize()"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().Initialize(), this.html.Facebook().Initialize()));
    Assert.True(this.html.Facebook().Initialize() is FacebookInitializationWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.ActivityFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void ActivityFeed_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().ActivityFeed(), this.html.Facebook().ActivityFeed()));
    Assert.True(this.html.Facebook().ActivityFeed() is FacebookActivityFeedWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.RecommendationsFeed()"/> method.</para>
  /// </summary>
  [Fact]
  public void RecommendationsFeed_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().RecommendationsFeed(), this.html.Facebook().RecommendationsFeed()));
    Assert.True(this.html.Facebook().RecommendationsFeed() is FacebookRecommendationsFeedWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().Comments(), this.html.Facebook().Comments()));
    Assert.True(this.html.Facebook().Comments() is FacebookCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Facepile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Facepile_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().Facepile(), this.html.Facebook().Facepile()));
    Assert.True(this.html.Facebook().Facepile() is FacebookFacepileWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().FollowButton(), this.html.Facebook().FollowButton()));
    Assert.True(this.html.Facebook().FollowButton() is FacebookFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().LikeButton(), this.html.Facebook().LikeButton()));
    Assert.True(this.html.Facebook().LikeButton() is FacebookLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.LikeBox()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeBox_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().LikeBox(), this.html.Facebook().LikeBox()));
    Assert.True(this.html.Facebook().LikeBox() is FacebookLikeBoxWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Post()"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().Post(), this.html.Facebook().Post()));
    Assert.True(this.html.Facebook().Post() is FacebookPostWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.SendButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SendButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().SendButton(), this.html.Facebook().SendButton()));
    Assert.True(this.html.Facebook().SendButton() is FacebookSendButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(this.html.Facebook().Video(), this.html.Facebook().Video()));
    Assert.True(this.html.Facebook().Video() is FacebookVideoWidget);
  }
}