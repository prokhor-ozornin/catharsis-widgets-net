namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexHtmlHelper"/>
public class YandexHtmlHelper : IYandexHtmlHelper
{
  /// <inheritdoc cref="IYandexHtmlHelper.Analytics()"/>
  public IYandexAnalyticsWidget Analytics() => new YandexAnalyticsWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.LikeButton()"/>
  public IYandexLikeButtonWidget LikeButton() => new YandexLikeButtonWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.MoneyButton()"/>
  public IYandexMoneyButtonWidget MoneyButton() => new YandexMoneyButtonWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.MoneyDonateForm()"/>
  public IYandexMoneyDonateFormWidget MoneyDonateForm() => new YandexMoneyDonateFormWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.MoneyPaymentForm()"/>
  public IYandexMoneyPaymentFormWidget MoneyPaymentForm() => new YandexMoneyPaymentFormWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.SharePanel()"/>
  public IYandexSharePanelWidget SharePanel() => new YandexSharePanelWidget();

  /// <inheritdoc cref="IYandexHtmlHelper.Video()"/>
  public IYandexVideoWidget Video() => new YandexVideoWidget();
}