using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YandexWidgetCreator"/>.</para>
/// </summary>
public sealed class YandexWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().LikeButton(), this.html.Yandex().LikeButton()));
    Assert.True(this.html.Yandex().LikeButton() is YandexLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().MoneyButton(), this.html.Yandex().MoneyButton()));
    Assert.True(this.html.Yandex().MoneyButton() is YandexMoneyButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyDonateForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().MoneyDonateForm(), this.html.Yandex().MoneyDonateForm()));
    Assert.True(this.html.Yandex().MoneyDonateForm() is YandexMoneyDonateFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyPaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().MoneyPaymentForm(), this.html.Yandex().MoneyPaymentForm()));
    Assert.True(this.html.Yandex().MoneyPaymentForm() is YandexMoneyPaymentFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.SharePanel()"/> method.</para>
  /// </summary>
  [Fact]
  public void Share_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().SharePanel(), this.html.Yandex().SharePanel()));
    Assert.True(this.html.Yandex().SharePanel() is YandexSharePanelWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(this.html.Yandex().Video(), this.html.Yandex().Video()));
    Assert.True(this.html.Yandex().Video() is YandexVideoWidget);
  }
}