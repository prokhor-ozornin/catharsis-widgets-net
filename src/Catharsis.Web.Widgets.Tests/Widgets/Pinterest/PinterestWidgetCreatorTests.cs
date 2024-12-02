using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestWidgetsCreator"/>.</para>
/// </summary>
public sealed class PinterestWidgetsCreatorTests : ClassTest<PinterestWidgetsCreator>
{
  private readonly IPinterestWidgetsCreator widgets = Widgets.Web.Pinterest();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IPinterestWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Board()"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    widgets.Board().Should().BeOfType<PinterestBoardWidget>().And.NotBeSameAs(widgets.Board());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    widgets.FollowButton().Should().BeOfType<PinterestFollowButtonWidget>().And.NotBeSameAs(widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.PinItButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    widgets.PinItButton().Should().BeOfType<PinterestPinItButtonWidget>().And.NotBeSameAs(widgets.PinItButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Pin()"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    widgets.Pin().Should().BeOfType<PinterestPinWidget>().And.NotBeSameAs(widgets.Pin());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Profile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    widgets.Profile().Should().BeOfType<PinterestProfileWidget>().And.NotBeSameAs(widgets.Profile());
  }
}