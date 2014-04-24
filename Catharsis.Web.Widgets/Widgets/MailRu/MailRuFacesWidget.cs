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
    ///   <para>Whether to show or hide Faces box title.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show title, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuFacesWidget Title(bool show = true)
    {
      this.title = show;
      return this;
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
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.domain.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object> { { "domain", this.domain }, { "font", this.font }, { "width", this.width }, { "height", this.height } };
      
      if (!this.titleText.IsEmpty())
      {
        config["title"] = this.titleText;
      }
      if (!this.title)
      {
        config["notitle"] = true;
      }
      if (!this.titleColor.IsEmpty())
      {
        config["title-color"] = this.titleColor;
      }
      if (!this.backgroundColor.IsEmpty())
      {
        config["background"] = this.backgroundColor;
      }
      if (!this.borderColor.IsEmpty())
      {
        config["border"] = this.borderColor;
      }
      if (!this.textColor.IsEmpty())
      {
        config["color"] = this.textColor;
      }
      if (!this.hyperlinkColor.IsEmpty())
      {
        config["link-color"] = this.hyperlinkColor;
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