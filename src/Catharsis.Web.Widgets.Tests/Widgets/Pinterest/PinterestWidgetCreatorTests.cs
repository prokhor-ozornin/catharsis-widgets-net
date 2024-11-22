using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestWidgetsCreator"/>.</para>
/// </summary>
public sealed class PinterestWidgetsCreatorTests : ClassTest<PinterestWidgetsCreator>
{
  private readonly IPinterestWidgetsCreator widgetses = Widgets.Web.Pinterest();

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Board()"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Board(), widgetses.Board()));
    Assert.True(widgetses.Board() is PinterestBoardWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.False(ReferenceEquals(widgetses.FollowButton(), widgetses.FollowButton()));
    Assert.True(widgetses.FollowButton() is PinterestFollowButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.PinItButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    Assert.False(ReferenceEquals(widgetses.PinItButton(), widgetses.PinItButton()));
    Assert.True(widgetses.PinItButton() is PinterestPinItButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Pin()"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Pin(), widgetses.Pin()));
    Assert.True(widgetses.Pin() is PinterestPinWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Profile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    Assert.False(ReferenceEquals(widgetses.Profile(), widgetses.Profile()));
    Assert.True(widgetses.Profile() is PinterestProfileWidget);
  }
}