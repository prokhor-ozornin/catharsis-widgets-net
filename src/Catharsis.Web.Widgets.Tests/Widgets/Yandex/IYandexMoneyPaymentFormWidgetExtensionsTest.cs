using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyPaymentFormWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyPaymentFormWidgetExtensionsTest : Test
{
  private IYandexMoneyPaymentFormWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexMoneyPaymentFormWidgetExtensionsTest() => Widget = Fixture<IYandexMoneyPaymentFormWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Sum(IYandexMoneyPaymentFormWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyPaymentFormWidgetExtensions.Sum(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { double.NegativeZero, Fixture<double>.Create() }.ForEach(sum => Test(sum, Widget));
    }

    return;

    static void Test(double sum, IYandexMoneyPaymentFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal>("SumValue").Should().Be((decimal) sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Text(IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormText)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<YandexMoneyPaymentFormText>().ForEach(text => Test(text, Widget));
    }

    return;

    static void Test(YandexMoneyPaymentFormText text, IYandexMoneyPaymentFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be((byte) text);
  }
}