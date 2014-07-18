using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru Faces (People On Site) widget.</para>
  ///   <para>Requires MailRu scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/faces"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.MailRu(IWidgetsScriptsRenderer)"/>
  public class MailRuFacesWidget : HtmlWidget, IMailRuFacesWidget
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
      Assertion.NotEmpty(color);

      this.backgroundColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of Faces box background.</para>
    /// </summary>
    /// <returns>Background color.</returns>
    public string BackgroundColor()
    {
      return this.backgroundColor;
    }

    /// <summary>
    ///   <para>Color of Faces box border.</para>
    /// </summary>
    /// <param name="color">Border color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuFacesWidget BorderColor(string color)
    {
      Assertion.NotEmpty(color);

      this.borderColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of Faces box border.</para>
    /// </summary>
    /// <returns>Border color.</returns>
    public string BorderColor()
    {
      return this.borderColor;
    }

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
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    /// <summary>
    ///   <para>Domain of target site with which users have interacted.</para>
    /// </summary>
    /// <returns>Target site domain.</returns>
    public string Domain()
    {
      return this.domain;
    }

    /// <summary>
    ///   <para>Name of font, used for text labels.</para>
    /// </summary>
    /// <param name="font">Font name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="font"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="font"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuFacesWidget Font(string font)
    {
      Assertion.NotEmpty(font);

      this.font = font;
      return this;
    }

    /// <summary>
    ///   <para>Name of font, used for text labels.</para>
    /// </summary>
    /// <returns>Font name.</returns>
    public string Font()
    {
      return this.font;
    }

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
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Height of Faces box area.</para>
    /// </summary>
    /// <returns>Area height.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Color of Faces box hyperlinks.</para>
    /// </summary>
    /// <param name="color">Hyperlinks color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuFacesWidget HyperlinkColor(string color)
    {
      Assertion.NotEmpty(color);

      this.hyperlinkColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of Faces box hyperlinks.</para>
    /// </summary>
    /// <returns>Hyperlinks color.</returns>
    public string HyperlinkColor()
    {
      return this.hyperlinkColor;
    }

    /// <summary>
    ///   <para>Color of Faces box text labels.</para>
    /// </summary>
    /// <param name="color">Text color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuFacesWidget TextColor(string color)
    {
      Assertion.NotEmpty(color);

      this.textColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of Faces box text labels.</para>
    /// </summary>
    /// <returns>Text color.</returns>
    public string TextColor()
    {
      return this.textColor;
    }

    /// <summary>
    ///   <para>Whether to show or hide Faces box title.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show title, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuFacesWidget Title(bool show)
    {
      this.title = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show or hide Faces box title.</para>
    /// </summary>
    /// <returns><c>true</c> to show title, <c>false</c> to hide.</returns>
    public bool Title()
    {
      return this.title;
    }

    /// <summary>
    ///   <para>Color of Faces box title.</para>
    /// </summary>
    /// <param name="color">Title color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuFacesWidget TitleColor(string color)
    {
      Assertion.NotEmpty(color);

      this.titleColor = color;
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
      Assertion.NotEmpty(title);

      this.titleText = title;
      return this;
    }

    /// <summary>
    ///   <para>Title text label of Faces box.</para>
    /// </summary>
    /// <returns>Title text.</returns>
    public string TitleText()
    {
      return this.titleText;
    }

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
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of Faces box area.</para>
    /// </summary>
    /// <returns>Area width.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Domain().IsEmpty() || this.Width().IsEmpty() || this.Height().IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object>
      {
        { "domain", this.Domain() },
        { "font", this.Font() },
        { "width", this.Width() },
        { "height", this.Height() }
      };
      
      if (!this.TitleText().IsEmpty())
      {
        config["title"] = this.TitleText();
      }
      if (!this.Title())
      {
        config["notitle"] = true;
      }
      if (!this.TitleColor().IsEmpty())
      {
        config["title-color"] = this.TitleColor();
      }
      if (!this.BackgroundColor().IsEmpty())
      {
        config["background"] = this.BackgroundColor();
      }
      if (!this.BorderColor().IsEmpty())
      {
        config["border"] = this.BorderColor();
      }
      if (!this.TextColor().IsEmpty())
      {
        config["color"] = this.TextColor();
      }
      if (!this.HyperlinkColor().IsEmpty())
      {
        config["link-color"] = this.HyperlinkColor();
      }

      return new TagBuilder("a")
        .Attribute("href", "http://connect.mail.ru/share_friends?{0}".FormatSelf(config.ToUrlQuery()))
        .Attribute("rel", config.Json())
        .CssClass("mrc__plugin_share_friends")
        .InnerHtml("Друзья")
        .ToString();
    }
  }
}