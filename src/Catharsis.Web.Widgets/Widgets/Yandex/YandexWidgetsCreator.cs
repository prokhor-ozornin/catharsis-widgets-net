namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexWidgetsCreator"/>
public class YandexWidgetsCreator : IYandexWidgetsCreator
{
  /// <inheritdoc cref="IYandexWidgetsCreator.Analytics()"/>
  public IYandexAnalyticsWidget Analytics() => new YandexAnalyticsWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.LikeButton()"/>
  public IYandexLikeButtonWidget LikeButton() => new YandexLikeButtonWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyButton()"/>
  public IYandexMoneyButtonWidget MoneyButton() => new YandexMoneyButtonWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyDonateForm()"/>
  public IYandexMoneyDonateFormWidget MoneyDonateForm() => new YandexMoneyDonateFormWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyPaymentForm()"/>
  public IYandexMoneyPaymentFormWidget MoneyPaymentForm() => new YandexMoneyPaymentFormWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.SharePanel()"/>
  public IYandexSharePanelWidget SharePanel() => new YandexSharePanelWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.Video()"/>
  public IYandexVideoWidget Video() => new YandexVideoWidget();
}