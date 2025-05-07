using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFacePileWidget"/>
public class FacebookFacePileWidget : WebWidget, IFacebookFacePileWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ActionsValue { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? MaxRowsValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PhotoSizeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
  public virtual IFacebookFacePileWidget Actions(IEnumerable<string> actions)
  {
    ActionsValue = actions ?? throw new ArgumentNullException(nameof(actions));

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public virtual IFacebookFacePileWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
      
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Height(string)"/>
  public virtual IFacebookFacePileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows(byte)"/>
  public virtual IFacebookFacePileWidget MaxRows(byte count)
  {
    MaxRowsValue = count;
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public virtual IFacebookFacePileWidget PhotoSize(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    PhotoSizeValue = size;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Url(string)"/>
  public virtual IFacebookFacePileWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Width(string)"/>
  public virtual IFacebookFacePileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookFacePileWidget
  {
    ActionsValue = ActionsValue?.ToArray(),
    ColorSchemeValue = ColorSchemeValue,
    HeightValue = HeightValue,
    MaxRowsValue = MaxRowsValue,
    PhotoSizeValue = PhotoSizeValue,
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlValue)
      .Attribute("data-action", ActionsValue.Any() ? ActionsValue.Join(",") : null)
      .Attribute("data-size", PhotoSizeValue)
      .Attribute("data-width", WidthValue)
      .Attribute("data-height", HeightValue)
      .Attribute("data-max-rows", MaxRowsValue)
      .Attribute("data-colorscheme", ColorSchemeValue)
      .CssClass("fb-facepile")
      .ToString();
}