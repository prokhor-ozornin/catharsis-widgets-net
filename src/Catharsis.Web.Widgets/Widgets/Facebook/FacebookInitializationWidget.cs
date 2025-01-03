using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookInitializationWidget"/>
public class FacebookInitializationWidget : WebWidget, IFacebookInitializationWidget
{
  private string appId;

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId(string)"/>
  public IFacebookInitializationWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    appId = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId()"/>
  public string AppId() => appId;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AppId().IsEmpty())
    {
      return string.Empty;
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", "fb-root"))
      .Append(string.Format(resources.facebook_initialize_js, AppId()))
      .ToString();
  }
}