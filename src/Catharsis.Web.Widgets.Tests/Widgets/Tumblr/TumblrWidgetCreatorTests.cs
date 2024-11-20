using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="TumblrWidgetCreator"/></para>
/// </summary>
public sealed class TumblrWidgetCreatorTests : ClassTest<TumblrWidgetCreator>
{
  private readonly ITumblrWidgetCreator widgets = Widgets.Web.Tumblr();

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is TumblrFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetCreator.ShareButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void ShareButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.ShareButton(), widgets.ShareButton()));
    Assert.True(widgets.ShareButton() is TumblrShareButtonWidget);
  }
}