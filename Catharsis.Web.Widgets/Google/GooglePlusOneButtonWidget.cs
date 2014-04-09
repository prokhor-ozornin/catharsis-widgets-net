using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Google "+1" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://developers.google.com/+/web/+1button/?hl=en"/>
  public sealed class GooglePlusOneButtonWidget : HtmlWidgetBase, IGooglePlusOneButtonWidget
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
    ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="recommendations"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IGooglePlusOneButtonWidget Recommendations(bool recommendations = true)
    {
      this.recommendations = recommendations;
      return this;
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("g:plusone", tag => tag
        .Attribute("href", this.url)
        .Attribute("size", this.size)
        .Attribute("annotation", this.annotation)
        .Attribute("width", this.width)
        .Attribute("align", this.alignment)
        .Attribute("data-callback", this.callback)
        .Attribute("data-recommendations", this.recommendations)));
    }
  }
}