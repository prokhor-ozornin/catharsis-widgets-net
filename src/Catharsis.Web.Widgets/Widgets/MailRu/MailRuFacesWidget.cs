using System.Web.Mvc;
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

  /// <summary>
  ///   <para>Color of Faces box background.</para>
  /// </summary>
  /// <param name="color">Background color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Faces box background.</para>
  /// </summary>
  /// <returns>Background color.</returns>
  public string BackgroundColor() => backgroundColor;

  /// <summary>
  ///   <para>Color of Faces box border.</para>
  /// </summary>
  /// <param name="color">Border color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget BorderColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    borderColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Faces box border.</para>
  /// </summary>
  /// <returns>Border color.</returns>
  public string BorderColor() => borderColor;

  /// <summary>
  ///   <para>Domain of target site with which users have interacted.</para>
  /// </summary>
  /// <param name="domain">Target site domain.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuFacesWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <summary>
  ///   <para>Domain of target site with which users have interacted.</para>
  /// </summary>
  /// <returns>Target site domain.</returns>
  public string Domain() => domain;

  /// <summary>
  ///   <para>Name of font, used for text labels.</para>
  /// </summary>
  /// <param name="font">Font name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="font"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="font"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget Font(string font)
  {
    if (font is null) throw new ArgumentNullException(nameof(font));
    if (font.IsEmpty()) throw new ArgumentException(nameof(font));

    this.font = font;
    return this;
  }

  /// <summary>
  ///   <para>Name of font, used for text labels.</para>
  /// </summary>
  /// <returns>Font name.</returns>
  public string Font() => font;

  /// <summary>
  ///   <para>Height of Faces box area.</para>
  /// </summary>
  /// <param name="height">Area height.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuFacesWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>Height of Faces box area.</para>
  /// </summary>
  /// <returns>Area height.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Color of Faces box hyperlinks.</para>
  /// </summary>
  /// <param name="color">Hyperlinks color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget HyperlinkColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    hyperlinkColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Faces box hyperlinks.</para>
  /// </summary>
  /// <returns>Hyperlinks color.</returns>
  public string HyperlinkColor() => hyperlinkColor;

  /// <summary>
  ///   <para>Color of Faces box text labels.</para>
  /// </summary>
  /// <param name="color">Text color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Faces box text labels.</para>
  /// </summary>
  /// <returns>Text color.</returns>
  public string TextColor() => textColor;

  /// <summary>
  ///   <para>Whether to show or hide Faces box title.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show title, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IMailRuFacesWidget Title(bool show)
  {
    title = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show or hide Faces box title.</para>
  /// </summary>
  /// <returns><c>true</c> to show title, <c>false</c> to hide.</returns>
  public bool Title() => title;

  /// <summary>
  ///   <para>Color of Faces box title.</para>
  /// </summary>
  /// <param name="color">Title color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget TitleColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    titleColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Faces box title.</para>
  /// </summary>
  /// <returns>Title color.</returns>
  public string TitleColor()
  {
    return this.titleColor;
  }

  /// <summary>
  ///   <para>Title text label of Faces box.</para>
  /// </summary>
  /// <param name="title">Title text.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuFacesWidget TitleText(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    titleText = title;
    return this;
  }

  /// <summary>
  ///   <para>Title text label of Faces box.</para>
  /// </summary>
  /// <returns>Title text.</returns>
  public string TitleText() => titleText;

  /// <summary>
  ///   <para>Width of Faces box area.</para>
  /// </summary>
  /// <param name="width">Area width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuFacesWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Width of Faces box area.</para>
  /// </summary>
  /// <returns>Area width.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
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