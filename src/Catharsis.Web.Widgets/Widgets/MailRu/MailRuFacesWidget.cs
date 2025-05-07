using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuFacesWidget"/>
public class MailRuFacesWidget : WebWidget, IMailRuFacesWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BackgroundColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BorderColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FontValue { get; set; } = nameof(MailRuFacesFont.Arial);

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HyperlinkColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TitleValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleTextValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor(string)"/>
  public virtual IMailRuFacesWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor(string)"/>
  public virtual IMailRuFacesWidget BorderColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BorderColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Domain(string)"/>
  public virtual IMailRuFacesWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainValue = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Font(string)"/>
  public virtual IMailRuFacesWidget Font(string font)
  {
    if (font is null) throw new ArgumentNullException(nameof(font));
    if (font.IsEmpty()) throw new ArgumentException(nameof(font));

    FontValue = font;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Height(string)"/>
  public virtual IMailRuFacesWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor(string)"/>
  public virtual IMailRuFacesWidget HyperlinkColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    HyperlinkColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor(string)"/>
  public virtual IMailRuFacesWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Title(bool)"/>
  public virtual IMailRuFacesWidget Title(bool enabled)
  {
    TitleValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor(string)"/>
  public virtual IMailRuFacesWidget TitleColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TitleColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText(string)"/>
  public virtual IMailRuFacesWidget TitleText(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleTextValue = title;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Width(string)"/>
  public virtual IMailRuFacesWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuFacesWidget
  {
    BackgroundColorValue = BackgroundColorValue,
    BorderColorValue = BorderColorValue,
    DomainValue = DomainValue,
    FontValue = FontValue,
    HeightValue = HeightValue,
    HyperlinkColorValue = HyperlinkColorValue,
    TextColorValue = TextColorValue,
    TitleValue = TitleValue,
    TitleColorValue = TitleColorValue,
    TitleTextValue = TitleTextValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (DomainValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "domain", DomainValue },
      { "font", FontValue },
      { "width", WidthValue },
      { "height", HeightValue }
    };
      
    if (!TitleTextValue.IsUnset())
    {
      config["title"] = TitleTextValue;
    }
    
    if (!TitleValue)
    {
      config["notitle"] = true;
    }
    
    if (!TitleColorValue.IsUnset())
    {
      config["title-color"] = TitleColorValue;
    }
    
    if (!BackgroundColorValue.IsUnset())
    {
      config["background"] = BackgroundColorValue;
    }
    
    if (!BorderColorValue.IsUnset())
    {
      config["border"] = BorderColorValue;
    }
    
    if (!TextColorValue.IsUnset())
    {
      config["color"] = TextColorValue;
    }
    
    if (!HyperlinkColorValue.IsUnset())
    {
      config["link-color"] = HyperlinkColorValue;
    }

    return new TagBuilder("a")
      .Attribute("href", $"http://connect.mail.ru/share_friends?${config.ToUrlQuery()}")
      .Attribute("rel", config.Json())
      .CssClass("mrc__plugin_share_friends")
      .Html("Друзья")
      .ToString();
  }
}