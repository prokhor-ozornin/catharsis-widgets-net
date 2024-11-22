using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleWidgetsCreator"/>.</para>
/// </summary>
public sealed class GoogleWidgetsCreatorTests : ClassTest<GoogleWidgetsCreator>
{
  private readonly IGoogleWidgetsCreator widgets = Widgets.Web.Google();

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.Analytics()"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    widgets.Analytics().Should().BeOfType<GoogleAnalyticsWidget>().And.NotBeSameAs(widgets.Analytics());
  }

  /*/// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.Map()"/> method.</para>
  /// </summary>
  [Fact]
  public void Map_Method()
  {
    widgetses.Map().Should().BeOfType<GoogleMapWidget>().And.NotBeSameAs(widgetses.Map());
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.PlusOneButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PlusOneButton_Method()
  {
    widgets.PlusOneButton().Should().BeOfType<GooglePlusOneButtonWidget>().And.NotBeSameAs(widgets.PlusOneButton());
  }
}