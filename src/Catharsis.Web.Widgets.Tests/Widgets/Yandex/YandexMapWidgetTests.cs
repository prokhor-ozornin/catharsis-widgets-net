using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YandexMapWidget"/>.</para>
/// </summary>
public sealed class YandexMapWidgetTests
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMapWidget>();

    var widget = new YandexMapWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMapWidget.ToHtml"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtmlString_Method()
  {
    throw new NotImplementedException();
  }
}