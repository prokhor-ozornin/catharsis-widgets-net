using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMapWidget"/>.</para>
/// </summary>
public sealed class YandexMapWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMapWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsUnset())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}