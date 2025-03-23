namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexWidgetsCreator"/>
public class YandexWidgetsCreator : IYandexWidgetsCreator
{
  /// <inheritdoc cref="IYandexWidgetsCreator.Analytics()"/>
  public virtual IYandexAnalyticsWidget Analytics() => new YandexAnalyticsWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.LikeButton()"/>
  public virtual IYandexLikeButtonWidget LikeButton() => new YandexLikeButtonWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyButton()"/>
  public virtual IYandexMoneyButtonWidget MoneyButton() => new YandexMoneyButtonWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyDonateForm()"/>
  public virtual IYandexMoneyDonateFormWidget MoneyDonateForm() => new YandexMoneyDonateFormWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.MoneyPaymentForm()"/>
  public virtual IYandexMoneyPaymentFormWidget MoneyPaymentForm() => new YandexMoneyPaymentFormWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.SharePanel()"/>
  public virtual IYandexSharePanelWidget SharePanel() => new YandexSharePanelWidget();

  /// <inheritdoc cref="IYandexWidgetsCreator.Video()"/>
  public virtual IYandexVideoWidget Video() => new YandexVideoWidget();
}