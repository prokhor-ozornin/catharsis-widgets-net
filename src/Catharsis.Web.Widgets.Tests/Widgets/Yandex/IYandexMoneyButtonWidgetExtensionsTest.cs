using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Color(IYandexMoneyButtonWidget, YandexMoneyButtonColor)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Color(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexMoneyButtonWidget();
      Enum.GetValues<YandexMoneyButtonColor>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyButtonColor color, IYandexMoneyButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ColorProperty").Should().Be(color.ToString().ToLowerInvariant());
    }
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

      var widget = new YandexMoneyButtonWidget();
      Enum.GetValues<YandexMoneyButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyButtonSize size, IYandexMoneyButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Sum(IYandexMoneyButtonWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyButtonWidgetExtensions.Sum(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexMoneyButtonWidget();
      new[] { double.MinValue, double.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(double sum, IYandexMoneyButtonWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.GetPropertyValue<decimal>("SumProperty").Should().Be((decimal) sum);
    }
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

      var widget = new YandexMoneyButtonWidget();
      Enum.GetValues<YandexMoneyButtonText>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyButtonText text, IYandexMoneyButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("TextProperty").Should().Be((byte) text);
    }
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

      var widget = new YandexMoneyButtonWidget();
      Enum.GetValues<YandexMoneyButtonType>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyButtonType type, IYandexMoneyButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("TypeProperty").Should().Be(type.ToString().ToLowerInvariant());
    }
  }
}