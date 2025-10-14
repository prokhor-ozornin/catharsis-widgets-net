using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Test set for class <see cref="AddThisWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="AddThisWidgetsCreator"/>
public sealed class AddThisWidgetsCreatorTest : Test
{
  private IAddThisWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.AddThis();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(AddThisWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IAddThisWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWidgetsCreator.SmartLayers()"/> method.</para>
  /// </summary>
  [Fact]
  public void SmartLayers_Method()
  {
    Widgets.SmartLayers().Should().BeOfType<AddThisSmartLayersWidget>().And.NotBeSameAs(Widgets.SmartLayers());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWidgetsCreator.ShareButtons()"/> method.</para>
  /// </summary>
  [Fact]
  public void ShareButtons_Method()
  {
    Widgets.ShareButtons().Should().BeOfType<AddThisShareButtonsWidget>().And.NotBeSameAs(Widgets.ShareButtons());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWidgetsCreator.FollowButtons()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButtons_Method()
  {
    Widgets.FollowButtons().Should().BeOfType<AddThisFollowButtonsWidget>().And.NotBeSameAs(Widgets.FollowButtons());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWidgetsCreator.WelcomeBar()"/> method.</para>
  /// </summary>
  [Fact]
  public void WelcomeBar_Method()
  {
    Widgets.WelcomeBar().Should().BeOfType<AddThisWelcomeBarWidget>().And.NotBeSameAs(Widgets.WelcomeBar());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWidgetsCreator.TrendingContent()"/> method.</para>
  /// </summary>
  [Fact]
  public void TrendingContent_Method()
  {
    Widgets.TrendingContent().Should().BeOfType<AddThisTrendingContentWidget>().And.NotBeSameAs(Widgets.TrendingContent());
  }
}