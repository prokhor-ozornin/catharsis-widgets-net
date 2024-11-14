using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="TumblrWidgetCreator"/></para>
/// </summary>
public sealed class TumblrWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Tumblr().FollowButton(), this.html.Tumblr().FollowButton()));
    Assert.True(this.html.Tumblr().FollowButton() is TumblrFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetCreator.ShareButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Tumblr().ShareButton(), this.html.Tumblr().ShareButton()));
    Assert.True(this.html.Tumblr().ShareButton() is TumblrShareButtonWidget);
  }
}