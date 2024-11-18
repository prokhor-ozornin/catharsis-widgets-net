using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="PinterestWidgetCreator"/>.</para>
/// </summary>
public sealed class PinterestWidgetCreatorTests
{
  private readonly IPinterestWidgetCreator widgets = Widgets.Web.Pinterest();

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetCreator.Board()"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    Assert.False(ReferenceEquals(widgets.Board(), widgets.Board()));
    Assert.True(widgets.Board() is PinterestBoardWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.FollowButton(), widgets.FollowButton()));
    Assert.True(widgets.FollowButton() is PinterestFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetCreator.PinItButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.PinItButton(), widgets.PinItButton()));
    Assert.True(widgets.PinItButton() is PinterestPinItButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetCreator.Pin()"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    Assert.False(ReferenceEquals(widgets.Pin(), widgets.Pin()));
    Assert.True(widgets.Pin() is PinterestPinWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetCreator.Profile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    Assert.False(ReferenceEquals(widgets.Profile(), widgets.Profile()));
    Assert.True(widgets.Profile() is PinterestProfileWidget);
  }
}