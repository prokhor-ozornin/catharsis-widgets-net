using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RobokassaWidgetsCreator"/>.</para>
/// </summary>
public sealed class RobokassaWidgetsCreatorTest : Test
{
  private IRobokassaWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Robokassa();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="RobokassaWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(RobokassaWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IRobokassaWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RobokassaWidgetsCreator.PaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void PaymentForm_Method()
  {
    Widgets.PaymentForm().Should().BeOfType<RobokassaPaymentFormWidget>().And.NotBeSameAs(Widgets.PaymentForm());
  }
}