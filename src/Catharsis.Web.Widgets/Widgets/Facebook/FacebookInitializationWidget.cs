using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookInitializationWidget"/>
public class FacebookInitializationWidget : WebWidget, IFacebookInitializationWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AppIdProperty { get; set; }

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId(string)"/>
  public virtual IFacebookInitializationWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AppIdProperty.IsUnset() ? string.Empty : new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", "fb-root"))
      .Append(string.Format(resources.facebook_initialize_js, AppIdProperty))
      .ToString();
}