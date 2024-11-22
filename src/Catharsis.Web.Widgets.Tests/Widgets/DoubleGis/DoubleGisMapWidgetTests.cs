using Catharsis.Commons;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisMapWidgetTests : ClassTest<DoubleGisMapWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisMapWidget>();

    var widget = new DoubleGisContactsMapWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(string.Empty, new DoubleGisMapWidget());
    }

    return;

    static void Validate(string result, IDoubleGisMapWidget widget) => widget.ToHtml().Should().NotBeSameAs(widget.ToHtml()).And.Contain(result);
  }
}