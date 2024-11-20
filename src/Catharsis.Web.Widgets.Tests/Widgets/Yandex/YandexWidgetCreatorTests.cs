using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YandexWidgetCreator"/>.</para>
/// </summary>
public sealed class YandexWidgetCreatorTests : ClassTest<YandexWidgetCreator>
{
  private readonly IYandexWidgetCreator widgets = Widgets.Web.Yandex();

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is YandexLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyButton(), widgets.MoneyButton()));
    Assert.True(widgets.MoneyButton() is YandexMoneyButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyDonateForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyDonateForm(), widgets.MoneyDonateForm()));
    Assert.True(widgets.MoneyDonateForm() is YandexMoneyDonateFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.MoneyPaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyPaymentForm(), widgets.MoneyPaymentForm()));
    Assert.True(widgets.MoneyPaymentForm() is YandexMoneyPaymentFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.SharePanel()"/> method.</para>
  /// </summary>
  [Fact]
  public void Share_Method()
  {
    Assert.False(ReferenceEquals(widgets.SharePanel(), widgets.SharePanel()));
    Assert.True(widgets.SharePanel() is YandexSharePanelWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is YandexVideoWidget);
  }
}