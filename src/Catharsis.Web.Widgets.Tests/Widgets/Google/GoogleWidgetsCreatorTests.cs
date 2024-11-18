using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="GoogleWidgetsCreator"/>.</para>
/// </summary>
public sealed class GoogleWidgetsCreatorTests
{
  private readonly IGoogleWidgetsCreator widgets = Widgets.Web.Google();

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.Analytics()"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Assert.False(ReferenceEquals(widgets.Analytics(), widgets.Analytics()));
    Assert.True(widgets.Analytics() is GoogleAnalyticsWidget);
  }

  /*/// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.Map()"/> method.</para>
  /// </summary>
  [Fact]
  public void Map_Method()
  {
    Assert.False(ReferenceEquals(widgets.Map(), widgets.Map()));
    Assert.True(widgets.Map() is GoogleMapWidget);
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.PlusOneButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void PlusOneButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.PlusOneButton(), widgets.PlusOneButton()));
    Assert.True(widgets.PlusOneButton() is GooglePlusOneButtonWidget);
  }
}