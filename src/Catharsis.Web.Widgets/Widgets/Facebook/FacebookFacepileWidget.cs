using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFacePileWidget"/>
public class FacebookFacePileWidget : WebWidget, IFacebookFacePileWidget
{
  private IEnumerable<string> ActionsProperty { get; set; } = [];
  private string ColorSchemeProperty { get; set; }
  private string HeightProperty { get; set; }
  private byte? MaxRowsProperty { get; set; }
  private string PhotoSizeProperty { get; set; }
  private string UrlProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
  public IFacebookFacePileWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions()"/>
  public IEnumerable<string> Actions() => ActionsProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public IFacebookFacePileWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
      
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.Height(string)"/>
  public IFacebookFacePileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows(byte)"/>
  public IFacebookFacePileWidget MaxRows(byte count)
  {
    MaxRowsProperty = count;
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows()"/>
  public byte? MaxRows() => MaxRowsProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public IFacebookFacePileWidget PhotoSize(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    PhotoSizeProperty = size;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize()"/>
  public string PhotoSize() => PhotoSizeProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.Url(string)"/>
  public IFacebookFacePileWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IFacebookFacePileWidget.Width(string)"/>
  public IFacebookFacePileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-action", Actions().Any() ? Actions().Join(",") : null)
      .Attribute("data-size", PhotoSize())
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-max-rows", MaxRows())
      .Attribute("data-colorscheme", ColorScheme())
      .CssClass("fb-facepile")
      .ToString();
}