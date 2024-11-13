namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexWidgetCreator"/>
public class YandexWidgetCreator : IYandexWidgetCreator
{
  /// <inheritdoc cref="IYandexWidgetCreator.Analytics()"/>
  public IYandexAnalyticsWidget Analytics() => new YandexAnalyticsWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.LikeButton()"/>
  public IYandexLikeButtonWidget LikeButton() => new YandexLikeButtonWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.MoneyButton()"/>
  public IYandexMoneyButtonWidget MoneyButton() => new YandexMoneyButtonWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.MoneyDonateForm()"/>
  public IYandexMoneyDonateFormWidget MoneyDonateForm() => new YandexMoneyDonateFormWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.MoneyPaymentForm()"/>
  public IYandexMoneyPaymentFormWidget MoneyPaymentForm() => new YandexMoneyPaymentFormWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.SharePanel()"/>
  public IYandexSharePanelWidget SharePanel() => new YandexSharePanelWidget();

  /// <inheritdoc cref="IYandexWidgetCreator.Video()"/>
  public IYandexVideoWidget Video() => new YandexVideoWidget();
}