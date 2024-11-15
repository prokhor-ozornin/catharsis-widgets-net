using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFacePileWidget"/>
public class FacebookFacePileWidget : WebWidget, IFacebookFacePileWidget
{
  private IEnumerable<string> actions = [];
  private string colorScheme;
  private string height;
  private byte? maxRows;
  private string photoSize;
  private string url;
  private string width;

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
  public IFacebookFacePileWidget Actions(IEnumerable<string> actions)
  {
    this.actions = actions ?? throw new ArgumentNullException(nameof(actions));

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Actions()"/>
  public IEnumerable<string> Actions() => actions;

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public IFacebookFacePileWidget ColorScheme(string colorScheme)
  {
    if (colorScheme is null) throw new ArgumentNullException(nameof(colorScheme));
    if (colorScheme.IsEmpty()) throw new ArgumentException(nameof(colorScheme));

    this.colorScheme = colorScheme;
      
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookFacePileWidget.Height(string)"/>
  public IFacebookFacePileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows(byte)"/>
  public IFacebookFacePileWidget MaxRows(byte maxRows)
  {
    this.maxRows = maxRows;
    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.MaxRows()"/>
  public byte? MaxRows() => maxRows;

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public IFacebookFacePileWidget PhotoSize(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    photoSize = size;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.PhotoSize()"/>
  public string PhotoSize() => photoSize;

  /// <inheritdoc cref="IFacebookFacePileWidget.Url(string)"/>
  public IFacebookFacePileWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IFacebookFacePileWidget.Width(string)"/>
  public IFacebookFacePileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IFacebookFacePileWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", Url() ?? (HttpContext.Current is not null ? HttpContext.Current.Request.Url.ToString() : null))
      .Attribute("data-action", Actions().Any() ? Actions().Join(",") : null)
      .Attribute("data-size", PhotoSize())
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-max-rows", MaxRows())
      .Attribute("data-colorscheme", ColorScheme())
      .CssClass("fb-facepile")
      .ToString();
  }
}