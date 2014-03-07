using System;
using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Surfingbird "Surf" button.</para>
  ///   <para>Requires <see cref="WidgetsScripts.SurfingbirdSurf"/> script to be included.</para>
  ///   <seealso cref="http://surfingbird.ru/publishers/surfbutton"/>
  /// </summary>
  public sealed class SurfingbirdSurfButtonWidget : HtmlWidgetBase<ISurfingbirdSurfButtonWidget>, ISurfingbirdSurfButtonWidget
  {
    private string url;
    private string layout = SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant();
    private string width;
    private string height;
    private bool counter;
    private string label = "Surf";
    private string color;

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
    ///   <para>Whether to render share counter next to a button. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="counter"><c>true</c> to show counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public ISurfingbirdSurfButtonWidget Counter(bool counter = true)
    {
      this.counter = counter;
      return this;
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "layout", "{0}{1}{2}".FormatSelf(this.layout, this.counter ? string.Empty : "-nocount", this.color.IsEmpty() ? string.Empty : "-" + this.color) } };
      if (!this.url.IsEmpty())
      {
        config["url"] = this.url;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("target", "_blank")
        .Attribute("href", "http://surfingbird.ru/share")
        .Attribute("data-surf-config", config.Json())
        .InnerHtml(this.label)
        .AddCssClass("surfinbird__like_button")));
    }
  }
}