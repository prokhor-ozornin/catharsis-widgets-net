using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexMoneyButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexMoneyButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Color(IYandexMoneyButtonWidget, YandexMoneyButtonColor)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyButtonWidgetExtensions.Color(null, YandexMoneyButtonColor.Orange));

      new YandexMoneyButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Color(YandexMoneyButtonColor.Black), widget));
        Assert.Equal("black", widget.Color());
      });
      new YandexMoneyButtonWidget().With(widget => Assert.Equal("orange", widget.Color(YandexMoneyButtonColor.Orange).Color()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal("white", widget.Color(YandexMoneyButtonColor.White).Color()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Size(IYandexMoneyButtonWidget, YandexMoneyButtonSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyButtonWidgetExtensions.Size(null, YandexMoneyButtonSize.Large));

      new YandexMoneyButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Size(YandexMoneyButtonSize.Large), widget));
        Assert.Equal("l", widget.Size());
      });
      new YandexMoneyButtonWidget().With(widget => Assert.Equal("m", widget.Size(YandexMoneyButtonSize.Medium).Size()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal("s", widget.Size(YandexMoneyButtonSize.Small).Size()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Sum(IYandexMoneyButtonWidget, double)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyButtonWidgetExtensions.Sum(null, 0));

      new YandexMoneyButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sum(1.0), widget));
        Assert.Equal((decimal) 1.0, widget.Sum());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Text(IYandexMoneyButtonWidget, YandexMoneyButtonText)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyButtonWidgetExtensions.Text(null, YandexMoneyButtonText.Pay));

      new YandexMoneyButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Text(YandexMoneyButtonText.Pay), widget));
        Assert.Equal(1, widget.Text());
      });
      new YandexMoneyButtonWidget().With(widget => Assert.Equal(2, widget.Text(YandexMoneyButtonText.Buy).Text()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal(3, widget.Text(YandexMoneyButtonText.Transfer).Text()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal(4, widget.Text(YandexMoneyButtonText.Donate).Text()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal(5, widget.Text(YandexMoneyButtonText.Give).Text()));
      new YandexMoneyButtonWidget().With(widget => Assert.Equal(6, widget.Text(YandexMoneyButtonText.Support).Text()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyButtonWidgetExtensions.Type(IYandexMoneyButtonWidget, YandexMoneyButtonType)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyButtonWidgetExtensions.Type(null, YandexMoneyButtonType.Wallet));

      new YandexMoneyButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Type(YandexMoneyButtonType.Card), widget));
        Assert.Equal("any-card-payment-type", widget.Type());
      });
      new YandexMoneyButtonWidget().With(widget => Assert.Equal("yamoney-payment-type", widget.Type(YandexMoneyButtonType.Wallet).Type()));
    }
  }
}