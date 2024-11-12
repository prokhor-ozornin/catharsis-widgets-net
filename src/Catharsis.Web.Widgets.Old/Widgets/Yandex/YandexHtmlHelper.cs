namespace Catharsis.Web.Widgets
{
  internal sealed class YandexHtmlHelper : IYandexHtmlHelper
  {
    public IYandexAnalyticsWidget Analytics() => new YandexAnalyticsWidget();

    public IYandexLikeButtonWidget LikeButton() => new YandexLikeButtonWidget();

    public IYandexMoneyButtonWidget MoneyButton() => new YandexMoneyButtonWidget();

    public IYandexMoneyDonateFormWidget MoneyDonateForm() => new YandexMoneyDonateFormWidget();

    public IYandexMoneyPaymentFormWidget MoneyPaymentForm() => new YandexMoneyPaymentFormWidget();

    public IYandexSharePanelWidget SharePanel() => new YandexSharePanelWidget();

    public IYandexVideoWidget Video() => new YandexVideoWidget();
  }
}