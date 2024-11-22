using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMapWidget"/>.</para>
/// </summary>
public sealed class YandexMapWidgetTests : ClassTest<YandexMapWidget>
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
  ///   <para>Performs testing of <see cref="YandexMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();
  }
}