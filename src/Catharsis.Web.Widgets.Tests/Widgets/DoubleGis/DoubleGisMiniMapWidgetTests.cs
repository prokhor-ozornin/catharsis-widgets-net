using Catharsis.Commons;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisMiniMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisMiniMapWidgetTests : ClassTest<DoubleGisMiniMapWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisMiniMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisMiniMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisMiniMapWidget>();

    var widget = new DoubleGisMiniMapWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMiniMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(string.Empty, new DoubleGisMiniMapWidget());
    }

    return;

    static void Validate(string result, IDoubleGisMiniMapWidget widget) => widget.ToHtml().Should().NotBeSameAs(widget.ToHtml()).And.Contain(result);
  }
}