using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookInitializationWidget"/>
public class FacebookInitializationWidget : WebWidget, IFacebookInitializationWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AppIdValue { get; set; }

  /// <inheritdoc cref="IFacebookInitializationWidget.AppId(string)"/>
  public virtual IFacebookInitializationWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdValue = id;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookInitializationWidget
  {
    AppIdValue = AppIdValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AppIdValue.IsUnset() ? string.Empty : new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", "fb-root"))
      .Append(string.Format(resources.facebook_initialize_js, AppIdValue))
      .ToString();
}