using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyPaymentFormWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyPaymentFormWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Sum(IYandexMoneyPaymentFormWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyPaymentFormWidgetExtensions.Sum(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new YandexMoneyPaymentFormWidget().With(widget => new[] { double.NegativeZero }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(double sum, IYandexMoneyPaymentFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal>("SumProperty").Should().Be((decimal) sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Text(IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormText)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyPaymentFormWidget().With(widget => Enum.GetValues<YandexMoneyPaymentFormText>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(YandexMoneyPaymentFormText text, IYandexMoneyPaymentFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextProperty").Should().Be((byte) text);
  }
}