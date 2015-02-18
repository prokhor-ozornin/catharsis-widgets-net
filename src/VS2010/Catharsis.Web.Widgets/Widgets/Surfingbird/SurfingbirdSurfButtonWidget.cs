using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Surfingbird "Surf" button.</para>
  ///   <para>Requires Surfingbird scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://surfingbird.ru/publishers/surfbutton"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Surfingbird(IWidgetsScriptsRenderer)"/>
  public class SurfingbirdSurfButtonWidget : HtmlWidget, ISurfingbirdSurfButtonWidget
  {
    private string url;
    private string layout = SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant();
    private string width;
    private string height;
    private bool counter;
    private string label = "Surf";
    private string color;

    /// <summary>
    ///   <para>Text label's color. If not specified, default color combination is used.</para>
    /// </summary>
    /// <param name="color">Label's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Color(string color)
    {
      Assertion.NotEmpty(color);

      this.color = color;
      return this;
    }
    
    /// <summary>
    ///   <para>Text label's color. If not specified, default color combination is used.</para>
    /// </summary>
    /// <returns>Label's color.</returns>
    public string Color()
    {
      return this.color;
    }

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public ISurfingbirdSurfButtonWidget Counter(bool show)
    {
      this.counter = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show counter, <c>false</c> to hide.</returns>
    public bool Counter()
    {
      return this.counter;
    }

    /// <summary>
    ///   <para>Vertical height of the button. Default is 25px.</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Vertical height of the button. Default is 25px.</para>
    /// </summary>
    /// <returns>Height of button.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Text label to show on button. Default is "Surf".</para>
    /// </summary>
    /// <param name="label">Text label on button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Label(string label)
    {
      Assertion.NotEmpty(label);

      this.label = label;
      return this;
    }

    /// <summary>
    ///   <para>Text label to show on button. Default is "Surf".</para>
    /// </summary>
    /// <returns>Text label on button.</returns>
    public string Label()
    {
      return this.label;
    }

    /// <summary>
    ///   <para>Layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public string Layout()
    {
      return this.layout;
    }

    /// <summary>
    ///   <para>Specifies URL address of web page to "like". Default is current web page.</para>
    /// </summary>
    /// <param name="url">URL of web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>Specifies URL address of web page to "like". Default is current web page.</para>
    /// </summary>
    /// <returns>URL of web page.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>Horizontal width of the button. Default is 500px.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public ISurfingbirdSurfButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal width of the button. Default is 500px.</para>
    /// </summary>
    /// <returns>Width of button.</returns>
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
      var config = new Dictionary<string, object>
      {
        { "layout", "{0}{1}{2}".FormatSelf(this.Layout(), this.Counter() ? string.Empty : "-nocount", this.Color().IsEmpty() ? string.Empty : "-" + this.Color()) }
      };

      if (!this.Url().IsEmpty())
      {
        config["url"] = this.Url();
      }
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }
      if (!this.Height().IsEmpty())
      {
        config["height"] = this.Height();
      }

      return new TagBuilder("a")
        .Attribute("target", "_blank")
        .Attribute("href", "http://surfingbird.ru/share")
        .Attribute("data-surf-config", config.Json())
        .CssClass("surfinbird__like_button")
        .InnerHtml(this.Label())
        .ToString();
    }
  }
}