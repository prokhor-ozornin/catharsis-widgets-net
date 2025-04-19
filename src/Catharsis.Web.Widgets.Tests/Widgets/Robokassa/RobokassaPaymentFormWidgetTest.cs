using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RobokassaPaymentFormWidget"/>.</para>
/// </summary>
public sealed class RobokassaPaymentFormWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="RobokassaPaymentFormWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(RobokassaPaymentFormWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IRobokassaPaymentFormWidget>();

    using (new AssertionScope())
    {
      var widget = new RobokassaPaymentFormWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RobokassaPaymentFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
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