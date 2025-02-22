using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuFacesWidget"/>
public class MailRuFacesWidget : WebWidget, IMailRuFacesWidget
{
  private string BackgroundColorProperty { get; set; }
  private string BorderColorProperty { get; set; }
  private string DomainProperty { get; set; }
  private string FontProperty { get; set; } = MailRuFacesFont.Arial.ToString();
  private string HeightProperty { get; set; }
  private string HyperlinkColorProperty { get; set; }
  private string TextColorProperty { get; set; }
  private bool TitleProperty { get; set; } = true;
  private string TitleColorProperty { get; set; }
  private string TitleTextProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor(string)"/>
  public IMailRuFacesWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor()"/>
  public string BackgroundColor() => BackgroundColorProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor(string)"/>
  public IMailRuFacesWidget BorderColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BorderColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor()"/>
  public string BorderColor() => BorderColorProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.Domain(string)"/>
  public IMailRuFacesWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Domain()"/>
  public string Domain() => DomainProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.Font(string)"/>
  public IMailRuFacesWidget Font(string font)
  {
    if (font is null) throw new ArgumentNullException(nameof(font));
    if (font.IsEmpty()) throw new ArgumentException(nameof(font));

    FontProperty = font;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Font()"/>
  public string Font() => FontProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.Height(string)"/>
  public IMailRuFacesWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor(string)"/>
  public IMailRuFacesWidget HyperlinkColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    HyperlinkColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor()"/>
  public string HyperlinkColor() => HyperlinkColorProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor(string)"/>
  public IMailRuFacesWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor()"/>
  public string TextColor() => TextColorProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.Title(bool)"/>
  public IMailRuFacesWidget Title(bool enabled)
  {
    TitleProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Title()"/>
  public bool Title() => TitleProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor(string)"/>
  public IMailRuFacesWidget TitleColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TitleColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor()"/>
  public string TitleColor() => TitleColorProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText(string)"/>
  public IMailRuFacesWidget TitleText(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleTextProperty = title;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText()"/>
  public string TitleText() => TitleTextProperty;

  /// <inheritdoc cref="IMailRuFacesWidget.Width(string)"/>
  public IMailRuFacesWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Domain().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "domain", Domain() },
      { "font", Font() },
      { "width", Width() },
      { "height", Height() }
    };
      
    if (!TitleText().IsEmpty())
    {
      config["title"] = TitleText();
    }
    
    if (!Title())
    {
      config["notitle"] = true;
    }
    
    if (!TitleColor().IsEmpty())
    {
      config["title-color"] = TitleColor();
    }
    
    if (!BackgroundColor().IsEmpty())
    {
      config["background"] = BackgroundColor();
    }
    
    if (!BorderColor().IsEmpty())
    {
      config["border"] = BorderColor();
    }
    
    if (!TextColor().IsEmpty())
    {
      config["color"] = TextColor();
    }
    
    if (!HyperlinkColor().IsEmpty())
    {
      config["link-color"] = HyperlinkColor();
    }

    return new TagBuilder("a")
      .Attribute("href", $"http://connect.mail.ru/share_friends?${config.ToUrlQuery()}")
      .Attribute("rel", config.Json())
      .CssClass("mrc__plugin_share_friends")
      .Html("Друзья")
      .ToString();
  }
}