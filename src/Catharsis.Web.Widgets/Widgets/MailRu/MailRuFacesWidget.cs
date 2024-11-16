using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuFacesWidget"/>
public class MailRuFacesWidget : WebWidget, IMailRuFacesWidget
{
  private string backgroundColor;
  private string borderColor;
  private string domain;
  private string font = MailRuFacesFont.Arial.ToString();
  private string height;
  private string hyperlinkColor;
  private string textColor;
  private bool title = true;
  private string titleColor;
  private string titleText;
  private string width;

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor(string)"/>
  public IMailRuFacesWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BackgroundColor()"/>
  public string BackgroundColor() => backgroundColor;

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor(string)"/>
  public IMailRuFacesWidget BorderColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    borderColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.BorderColor()"/>
  public string BorderColor() => borderColor;

  /// <inheritdoc cref="IMailRuFacesWidget.Domain(string)"/>
  public IMailRuFacesWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Domain()"/>
  public string Domain() => domain;

  /// <inheritdoc cref="IMailRuFacesWidget.Font(string)"/>
  public IMailRuFacesWidget Font(string font)
  {
    if (font is null) throw new ArgumentNullException(nameof(font));
    if (font.IsEmpty()) throw new ArgumentException(nameof(font));

    this.font = font;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Font()"/>
  public string Font() => font;

  /// <inheritdoc cref="IMailRuFacesWidget.Height(string)"/>
  public IMailRuFacesWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor(string)"/>
  public IMailRuFacesWidget HyperlinkColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    hyperlinkColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.HyperlinkColor()"/>
  public string HyperlinkColor() => hyperlinkColor;

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor(string)"/>
  public IMailRuFacesWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TextColor()"/>
  public string TextColor() => textColor;

  /// <inheritdoc cref="IMailRuFacesWidget.Title(bool)"/>
  public IMailRuFacesWidget Title(bool show)
  {
    title = show;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Title()"/>
  public bool Title() => title;

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor(string)"/>
  public IMailRuFacesWidget TitleColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    titleColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleColor()"/>
  public string TitleColor() => titleColor;

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText(string)"/>
  public IMailRuFacesWidget TitleText(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    titleText = title;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.TitleText()"/>
  public string TitleText() => titleText;

  /// <inheritdoc cref="IMailRuFacesWidget.Width(string)"/>
  public IMailRuFacesWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IMailRuFacesWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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
      .InnerHtml("Друзья")
      .ToString();
  }
}