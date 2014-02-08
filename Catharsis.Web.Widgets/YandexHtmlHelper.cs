namespace Catharsis.Web.Widgets
{
  internal sealed class YandexHtmlHelper : IYandexHtmlHelper
  {
    public IYandexAnalyticsWidget Analytics()
    {
      return new YandexAnalyticsWidget();
    }

    public IYandexLikeButtonWidget Like()
    {
      return new YandexLikeButtonWidget();
    }

    public IYandexSharePanelWidget Share()
    {
      return new YandexSharePanelWidget();
    }

    public IYandexVideoWidget Video()
    {
      return new YandexVideoWidget();
    }

    public IYandexVideoLinkWidget VideoLink()
    {
      return new YandexVideoLinkWidget();
    }
  }
}