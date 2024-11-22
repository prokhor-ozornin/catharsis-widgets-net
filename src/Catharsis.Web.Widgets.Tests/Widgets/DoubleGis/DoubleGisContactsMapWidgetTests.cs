using Catharsis.Commons;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisContactsMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisContactsMapWidgetTests : ClassTest<DoubleGisContactsMapWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisContactsMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisContactsMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisContactsMapWidget>();

    var widget = new DoubleGisContactsMapWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisContactsMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(string.Empty, new DoubleGisContactsMapWidget());
    }

    return;

    static void Validate(string result, IDoubleGisContactsMapWidget widget) => widget.ToHtml().Should().NotBeSameAs(widget.ToHtml()).And.Contain(result);
  }
}