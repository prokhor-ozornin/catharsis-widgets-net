using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RobokassaPaymentFormWidget"/>.</para>
/// </summary>
public sealed class RobokassaPaymentFormWidgetTest : Test
{
  private IRobokassaPaymentFormWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public RobokassaPaymentFormWidgetTest() => Widget = Fixture.Create<IRobokassaPaymentFormWidget>();

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
  ///   <para>Performs testing of <see cref="RobokassaPaymentFormWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new RobokassaPaymentFormWidget());
      Test(Fixture.Create<RobokassaPaymentFormWidget>());
    }

    return;

    static void Test(IRobokassaPaymentFormWidget original)
    {
      var clone = original.Clone<IRobokassaPaymentFormWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RobokassaPaymentFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture.Create<RobokassaPaymentFormWidget>());
      throw new NotImplementedException();
    }

    return;

    static void Test(IRobokassaPaymentFormWidget widget, params string[] html)
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