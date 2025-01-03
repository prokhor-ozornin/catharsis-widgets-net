using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyPaymentFormWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyPaymentFormWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Sum(IYandexMoneyPaymentFormWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyPaymentFormWidgetExtensions.Sum(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexMoneyPaymentFormWidget();
      new[] { double.MinValue, double.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(double sum, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.Sum().Should().Be((decimal) sum);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Text(IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormText)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Enum.GetValues<YandexMoneyPaymentFormText>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyPaymentFormText text, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be((byte) text);
    }
  }
}