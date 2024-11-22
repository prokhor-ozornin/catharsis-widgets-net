using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrWidgetsCreator"/></para>
/// </summary>
public sealed class TumblrWidgetCreatorTests : ClassTest<TumblrWidgetsCreator>
{
  private readonly ITumblrWidgetsCreator widgets = Widgets.Web.Tumblr();

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is TumblrFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetsCreator.ShareButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.ShareButton(), widgets.ShareButton()));
    Assert.True(widgets.ShareButton() is TumblrShareButtonWidget);
  }
}