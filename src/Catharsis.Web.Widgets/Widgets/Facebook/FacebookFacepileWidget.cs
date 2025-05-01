using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFacePileWidget"/>
public class FacebookFacePileWidget : WebWidget, IFacebookFacePileWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ActionsProperty { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? MaxRowsProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PhotoSizeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
  public virtual IFacebookFacePileWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public virtual IFacebookFacePileWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
      
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Height(string)"/>
  public virtual IFacebookFacePileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows(byte)"/>
  public virtual IFacebookFacePileWidget MaxRows(byte count)
  {
    MaxRowsProperty = count;
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public virtual IFacebookFacePileWidget PhotoSize(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    PhotoSizeProperty = size;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Url(string)"/>
  public virtual IFacebookFacePileWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Width(string)"/>
  public virtual IFacebookFacePileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookFacePileWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlProperty)
      .Attribute("data-action", ActionsProperty.Any() ? ActionsProperty.Join(",") : null)
      .Attribute("data-size", PhotoSizeProperty)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-height", HeightProperty)
      .Attribute("data-max-rows", MaxRowsProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .CssClass("fb-facepile")
      .ToString();
}