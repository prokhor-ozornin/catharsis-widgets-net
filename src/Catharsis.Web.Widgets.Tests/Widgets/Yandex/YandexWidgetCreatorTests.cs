using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexWidgetsCreator"/>.</para>
/// </summary>
public sealed class YandexWidgetCreatorTests : ClassTest<YandexWidgetsCreator>
{
  private readonly IYandexWidgetsCreator widgets = Widgets.Web.Yandex();

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is YandexLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyButton(), widgets.MoneyButton()));
    Assert.True(widgets.MoneyButton() is YandexMoneyButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyDonateForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyDonateForm(), widgets.MoneyDonateForm()));
    Assert.True(widgets.MoneyDonateForm() is YandexMoneyDonateFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyPaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.False(ReferenceEquals(widgets.MoneyPaymentForm(), widgets.MoneyPaymentForm()));
    Assert.True(widgets.MoneyPaymentForm() is YandexMoneyPaymentFormWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.SharePanel()"/> method.</para>
  /// </summary>
  [Fact]
  public void Share_Method()
  {
    Assert.False(ReferenceEquals(widgets.SharePanel(), widgets.SharePanel()));
    Assert.True(widgets.SharePanel() is YandexSharePanelWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is YandexVideoWidget);
  }
}