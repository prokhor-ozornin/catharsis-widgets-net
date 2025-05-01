namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class YandexMapWidget : WebWidget, IYandexMapWidget
{
  public override object Clone() => new YandexMapWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    throw new NotImplementedException();
  }
}