using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexMoneyPaymentFormWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexMoneyPaymentFormWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Sum(IYandexMoneyPaymentFormWidget, double)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyPaymentFormWidgetExtensions.Sum(null, 0));

      new YandexMoneyPaymentFormWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sum(1.0), widget));
        Assert.Equal((decimal)1.0, widget.Sum());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyPaymentFormWidgetExtensions.Text(IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormText)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyPaymentFormWidgetExtensions.Text(null, YandexMoneyPaymentFormText.Pay));

      new YandexMoneyPaymentFormWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Text(YandexMoneyPaymentFormText.Pay), widget));
        Assert.Equal(1, widget.Text());
      });
      new YandexMoneyPaymentFormWidget().With(widget => Assert.Equal(2, widget.Text(YandexMoneyPaymentFormText.Buy).Text()));
      new YandexMoneyPaymentFormWidget().With(widget => Assert.Equal(3, widget.Text(YandexMoneyPaymentFormText.Transfer).Text()));
      new YandexMoneyPaymentFormWidget().With(widget => Assert.Equal(4, widget.Text(YandexMoneyPaymentFormText.Give).Text()));
    }
  }
}