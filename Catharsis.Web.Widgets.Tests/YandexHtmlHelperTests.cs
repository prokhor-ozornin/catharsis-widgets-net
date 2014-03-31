using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexHtmlHelper"/>.</para>
  /// </summary>
  public sealed class YandexHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.Like()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().Like(), this.html.Yandex().Like()));
      Assert.True(this.html.Yandex().Like() is YandexLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.MoneyButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().MoneyButton(), this.html.Yandex().MoneyButton()));
      Assert.True(this.html.Yandex().MoneyButton() is YandexMoneyButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.MoneyDonateForm()"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyDonateForm_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().MoneyDonateForm(), this.html.Yandex().MoneyDonateForm()));
      Assert.True(this.html.Yandex().MoneyDonateForm() is YandexMoneyDonateFormWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.MoneyPaymentForm()"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyPaymentForm_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().MoneyPaymentForm(), this.html.Yandex().MoneyPaymentForm()));
      Assert.True(this.html.Yandex().MoneyPaymentForm() is YandexMoneyPaymentFormWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.Share()"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().Share(), this.html.Yandex().Share()));
      Assert.True(this.html.Yandex().Share() is YandexSharePanelWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().Video(), this.html.Yandex().Video()));
      Assert.True(this.html.Yandex().Video() is YandexVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexHtmlHelper.VideoLink()"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.Yandex().VideoLink(), this.html.Yandex().VideoLink()));
      Assert.True(this.html.Yandex().VideoLink() is YandexVideoLinkWidget);
    }
  }
}