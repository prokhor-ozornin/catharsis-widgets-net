using Catharsis.Commons;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisMapWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisMapWidget>();

    using (new AssertionScope())
    {
      var widget = new DoubleGisContactsMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new DoubleGisMapWidget());
    }

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