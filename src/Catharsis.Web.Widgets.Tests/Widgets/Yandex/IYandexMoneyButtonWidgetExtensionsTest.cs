using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyButtonWidgetExtensionsTest : Test
{
  private IYandexMoneyButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexMoneyButtonWidgetExtensionsTest() => Widget = Fixture<IYandexMoneyButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Color(IYandexMoneyButtonWidget, YandexMoneyButtonColor)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Color(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<YandexMoneyButtonColor>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(YandexMoneyButtonColor color, IYandexMoneyButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Size(IYandexMoneyButtonWidget, YandexMoneyButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(YandexMoneyButtonSize.Small, "s", Widget);
      Test(YandexMoneyButtonSize.Medium, "m", Widget);
      Test(YandexMoneyButtonSize.Large, "l", Widget);
    }

    return;

    static void Test(YandexMoneyButtonSize size, string value, IYandexMoneyButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Sum(IYandexMoneyButtonWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Sum(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { double.NegativeZero, Fixture<double>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(double sum, IYandexMoneyButtonWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal>("SumValue").Should().Be((decimal) sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Text(IYandexMoneyButtonWidget, YandexMoneyButtonText)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Text(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<YandexMoneyButtonText>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(YandexMoneyButtonText text, IYandexMoneyButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be((byte) text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Type(IYandexMoneyButtonWidget, YandexMoneyButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(YandexMoneyButtonType.Card, "any-card-payment-type", Widget);
      Test(YandexMoneyButtonType.Wallet, "yamoney-payment-type", Widget);
    }

    return;

    static void Test(YandexMoneyButtonType type, string value, IYandexMoneyButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeValue").Should().Be(value);
  }
}