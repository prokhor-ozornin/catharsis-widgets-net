using Catharsis.Commons;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisContactsMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisContactsMapWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisContactsMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisContactsMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisContactsMapWidget>();

    using (new AssertionScope())
    {
      var widget = new DoubleGisContactsMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisContactsMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new DoubleGisContactsMapWidget());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
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