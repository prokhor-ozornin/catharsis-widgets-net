using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleWidgetsCreator"/>.</para>
/// </summary>
public sealed class GoogleWidgetsCreatorTests : ClassTest<GoogleWidgetsCreator>
{
  private IGoogleWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Google();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GoogleWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GoogleWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IGoogleWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleWidgetsCreator.Analytics()"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Widgets.Analytics().Should().BeOfType<GoogleAnalyticsWidget>().And.NotBeSameAs(Widgets.Analytics());
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
    Widgets.PlusOneButton().Should().BeOfType<GooglePlusOneButtonWidget>().And.NotBeSameAs(Widgets.PlusOneButton());
  }
}