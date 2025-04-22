using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuFacesWidget"/>
public class MailRuFacesWidget : WebWidget, IMailRuFacesWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BackgroundColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BorderColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FontProperty { get; set; } = MailRuFacesFont.Arial.ToString();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HyperlinkColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TitleProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleTextProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor(string)"/>
  public virtual IMailRuFacesWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor(string)"/>
  public virtual IMailRuFacesWidget BorderColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BorderColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Domain(string)"/>
  public virtual IMailRuFacesWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Font(string)"/>
  public virtual IMailRuFacesWidget Font(string font)
  {
    if (font is null) throw new ArgumentNullException(nameof(font));
    if (font.IsEmpty()) throw new ArgumentException(nameof(font));

    FontProperty = font;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Height(string)"/>
  public virtual IMailRuFacesWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor(string)"/>
  public virtual IMailRuFacesWidget HyperlinkColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    HyperlinkColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor(string)"/>
  public virtual IMailRuFacesWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Title(bool)"/>
  public virtual IMailRuFacesWidget Title(bool enabled)
  {
    TitleProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor(string)"/>
  public virtual IMailRuFacesWidget TitleColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TitleColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText(string)"/>
  public virtual IMailRuFacesWidget TitleText(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleTextProperty = title;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Width(string)"/>
  public virtual IMailRuFacesWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (DomainProperty.IsUnset() || WidthProperty.IsUnset() || HeightProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "domain", DomainProperty },
      { "font", FontProperty },
      { "width", WidthProperty },
      { "height", HeightProperty }
    };
      
    if (!TitleTextProperty.IsUnset())
    {
      config["title"] = TitleTextProperty;
    }
    
    if (!TitleProperty)
    {
      config["notitle"] = true;
    }
    
    if (!TitleColorProperty.IsUnset())
    {
      config["title-color"] = TitleColorProperty;
    }
    
    if (!BackgroundColorProperty.IsUnset())
    {
      config["background"] = BackgroundColorProperty;
    }
    
    if (!BorderColorProperty.IsUnset())
    {
      config["border"] = BorderColorProperty;
    }
    
    if (!TextColorProperty.IsUnset())
    {
      config["color"] = TextColorProperty;
    }
    
    if (!HyperlinkColorProperty.IsUnset())
    {
      config["link-color"] = HyperlinkColorProperty;
    }

    return new TagBuilder("a")
      .Attribute("href", $"http://connect.mail.ru/share_friends?${config.ToUrlQuery()}")
      .Attribute("rel", config.Json())
      .CssClass("mrc__plugin_share_friends")
      .Html("Друзья")
      .ToString();
  }
}