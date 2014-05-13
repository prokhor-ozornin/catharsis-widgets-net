using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexMoneyDonateFormWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexMoneyDonateFormWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.Sum(IYandexMoneyDonateFormWidget, double)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyDonateFormWidgetExtensions.Sum(null, 0));

      new YandexMoneyDonateFormWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sum(1.0), widget));
        Assert.Equal((decimal)1.0, widget.Sum());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.Text(IYandexMoneyDonateFormWidget, YandexMoneyDonateFormText)"/></para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexMoneyDonateFormWidgetExtensions.Text(null, YandexMoneyDonateFormText.Donate));

      new YandexMoneyDonateFormWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Text(YandexMoneyDonateFormText.Donate), widget));
        Assert.Equal(1, widget.Text());
      });
      new YandexMoneyDonateFormWidget().With(widget => Assert.Equal(2, widget.Text(YandexMoneyDonateFormText.Give).Text()));
      new YandexMoneyDonateFormWidget().With(widget => Assert.Equal(3, widget.Text(YandexMoneyDonateFormText.Transfer).Text()));
      new YandexMoneyDonateFormWidget().With(widget => Assert.Equal(4, widget.Text(YandexMoneyDonateFormText.Send).Text()));
      new YandexMoneyDonateFormWidget().With(widget => Assert.Equal(5, widget.Text(YandexMoneyDonateFormText.Support).Text()));
    }
  }
}