using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookInitializationWidget"/>
public class FacebookInitializationWidget : WebWidget, IFacebookInitializationWidget
{
  private string appId;

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId(string)"/>
  public IFacebookInitializationWidget AppId(string appId)
  {
    if (appId is null) throw new ArgumentNullException(nameof(appId));
    if (appId.IsEmpty()) throw new ArgumentException(nameof(appId));

    this.appId = appId;
    return this;
  }

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId()"/>
  public string AppId() => appId;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AppId().IsEmpty())
    {
      return string.Empty;
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", "fb-root"))
      .Append(string.Format(resources.facebook_initialize, AppId()))
      .ToString();
  }
}