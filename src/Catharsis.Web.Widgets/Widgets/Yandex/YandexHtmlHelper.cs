namespace Catharsis.Web.Widgets
{
  internal sealed class YandexHtmlHelper : IYandexHtmlHelper
  {
    public IYandexAnalyticsWidget Analytics()
    {
      return new YandexAnalyticsWidget();
    }

    public IYandexLikeButtonWidget LikeButton()
    {
      return new YandexLikeButtonWidget();
    }

    public IYandexMoneyButtonWidget MoneyButton()
    {
      return new YandexMoneyButtonWidget();
    }

    public IYandexMoneyDonateFormWidget MoneyDonateForm()
    {
      return new YandexMoneyDonateFormWidget();
    }

    public IYandexMoneyPaymentFormWidget MoneyPaymentForm()
    {
      return new YandexMoneyPaymentFormWidget();
    }

    public IYandexSharePanelWidget SharePanel()
    {
      return new YandexSharePanelWidget();
    }

    public IYandexVideoWidget Video()
    {
      return new YandexVideoWidget();
    }
  }
}