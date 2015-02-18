using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Google "+1" button.</para>
  ///   <para>Requires Google scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://developers.google.com/+/web/+1button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Google(IWidgetsScriptsRenderer)"/>
  public class GooglePlusOneButtonWidget : HtmlWidget, IGooglePlusOneButtonWidget
  {
    private string url;
    private string width;
    private string size;
    private string alignment;
    private string annotation;
    private string callback;
    private bool? recommendations;

    /// <summary>
    ///   <para>Horizontal alignment of the button assets within its frame.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Alignment(string alignment)
    {
      Assertion.NotEmpty(alignment);

      this.alignment = alignment;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal alignment of the button assets within its frame.</para>
    /// </summary>
    /// <returns>Horizontal alignment of the button.</returns>
    public string Alignment()
    {
      return this.alignment;
    }

    /// <summary>
    ///   <para>Annotation to display next to the button.</para>
    /// </summary>
    /// <param name="annotation">Annotation for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="annotation"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="annotation"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Annotation(string annotation)
    {
      Assertion.NotEmpty(annotation);

      this.annotation = annotation;
      return this;
    }

    /// <summary>
    ///   <para>Annotation to display next to the button.</para>
    /// </summary>
    /// <returns>Annotation for the button.</returns>
    public string Annotation()
    {
      return this.annotation;
    }

    /// <summary>
    ///   <para>Callback JavaScript function that is called after the user clicks the +1 button.</para>
    /// </summary>
    /// <param name="callback">Callback JavaScript function.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Callback(string callback)
    {
      Assertion.NotEmpty(callback);

      this.callback = callback;
      return this;
    }

    /// <summary>
    ///   <para>Callback JavaScript function that is called after the user clicks the +1 button.</para>
    /// </summary>
    /// <returns>Callback JavaScript function.</returns>
    public string Callback()
    {
      return this.callback;
    }

    /// <summary>
    ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IGooglePlusOneButtonWidget Recommendations(bool show)
    {
      this.recommendations = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show recommendations, <c>false</c> to hide.</returns>
    public bool? Recommendations()
    {
      return this.recommendations;
    }

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Size of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <returns>Size of the button.</returns>
    public string Size()
    {
      return this.size;
    }

    /// <summary>
    ///   <para>URL for the button. Default is current page's URL.</para>
    /// </summary>
    /// <param name="url">URL for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL for the button. Default is current page's URL.</para>
    /// </summary>
    /// <returns>URL for the button.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation. If the width is omitted, a button and its inline annotation use 450px.</para>
    /// </summary>
    /// <param name="width">Width of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IGooglePlusOneButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation. If the width is omitted, a button and its inline annotation use 450px.</para>
    /// </summary>
    /// <returns>Width of the button.</returns>
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
      return new TagBuilder("g:plusone")
        .Attribute("href", this.Url())
        .Attribute("size", this.Size())
        .Attribute("annotation", this.Annotation())
        .Attribute("width", this.Width())
        .Attribute("align", this.Alignment())
        .Attribute("data-callback", this.Callback())
        .Attribute("data-recommendations", this.Recommendations())
        .ToString();
    }
  }
}