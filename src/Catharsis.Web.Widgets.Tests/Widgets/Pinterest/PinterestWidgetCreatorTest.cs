using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestWidgetsCreator"/>.</para>
/// </summary>
public sealed class PinterestWidgetsCreatorTest : Test
{
  private IPinterestWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Pinterest();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(PinterestWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IPinterestWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Board()"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    Widgets.Board().Should().BeOfType<PinterestBoardWidget>().And.NotBeSameAs(Widgets.Board());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Widgets.FollowButton().Should().BeOfType<PinterestFollowButtonWidget>().And.NotBeSameAs(Widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.PinItButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    Widgets.PinItButton().Should().BeOfType<PinterestPinItButtonWidget>().And.NotBeSameAs(Widgets.PinItButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Pin()"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    Widgets.Pin().Should().BeOfType<PinterestPinWidget>().And.NotBeSameAs(Widgets.Pin());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestWidgetsCreator.Profile()"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    Widgets.Profile().Should().BeOfType<PinterestProfileWidget>().And.NotBeSameAs(Widgets.Profile());
  }
}