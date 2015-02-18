using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Like Box.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/like-box-for-pages"/>
  public class FacebookLikeBoxWidget : HtmlWidget, IFacebookLikeBoxWidget
  {
    private bool? border;
    private string colorScheme;
    private bool? faces;
    private bool? header;
    private string height;
    private bool? stream;
    private string url;
    private bool? wall;
    private string width;

    /// <summary>
    ///   <para>Whether or not to show a border around the plugin. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="border"><c>true</c> to show border, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeBoxWidget Border(bool border)
    {
      this.border = border;
      return this;
    }

    /// <summary>
    ///   <para>Whether or not to show a border around the plugin. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show border, <c>false</c> to hide.</returns>
    public bool? Border()
    {
      return this.border;
    }

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeBoxWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <returns>Color scheme of widget.</returns>
    public string ColorScheme()
    {
      return this.colorScheme;
    }

    /// <summary>
    ///   <para>Whether to display profile photos of people who like the page. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show profile photos, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeBoxWidget Faces(bool show)
    {
      this.faces = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to display profile photos of people who like the page. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show profile photos, <c>false</c> to hide.</returns>
    public bool? Faces()
    {
      return this.faces;
    }

    /// <summary>
    ///   <para>Whether to display the Facebook header at the top of the widget. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show header, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeBoxWidget Header(bool show)
    {
      this.header = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to display the Facebook header at the top of the widget. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show header, <c>false</c> to hide.</returns>
    public bool? Header()
    {
      return this.header;
    }

    /// <summary>
    ///   <para>The height of the widget in pixels. The default height varies based on number of faces to display, and whether the stream is displayed. With stream set to true and 10 photos displayed (via showFaces) the default height is 556px. With stream and show_faces both false, the default height is 63px.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeBoxWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>The height of the widget in pixels. The default height varies based on number of faces to display, and whether the stream is displayed. With stream set to true and 10 photos displayed (via showFaces) the default height is 556px. With stream and show_faces both false, the default height is 63px.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Specifies whether to display a stream of the latest posts by the Page. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show stream of posts, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeBoxWidget Stream(bool show)
    {
      this.stream = show;
      return this;
    }

    /// <summary>
    ///   <para>Specifies whether to display a stream of the latest posts by the Page. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show stream of posts, <c>false</c> to hide.</returns>
    public bool? Stream()
    {
      return this.stream;
    }

    /// <summary>
    ///   <para>The absolute URL of the Facebook Page that will be liked.</para>
    /// </summary>
    /// <param name="url">URL of target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookLikeBoxWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>The absolute URL of the Facebook Page that will be liked.</para>
    /// </summary>
    /// <returns>URL of target web page.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>For "place" Pages (Pages that have a physical location that can be used with check-ins), this specifies whether the stream contains posts by the Page or just check-ins from friends. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="include"><c>true</c> to include page's posts in the stream, <c>false</c> to exclude.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeBoxWidget Wall(bool include)
    {
      this.wall = include;
      return this;
    }

    /// <summary>
    ///   <para>For "place" Pages (Pages that have a physical location that can be used with check-ins), this specifies whether the stream contains posts by the Page or just check-ins from friends. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to include page's posts in the stream, <c>false</c> to exclude.</returns>
    public bool? Wall()
    {
      return this.wall;
    }

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 292. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeBoxWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 292. Default is 300.</para>
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
      if (this.Url().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("div")
        .Attribute("data-href", this.Url())
        .Attribute("data-width", this.Width())
        .Attribute("data-height", this.Height())
        .Attribute("data-colorscheme", this.ColorScheme())
        .Attribute("data-force-wall", this.Wall())
        .Attribute("data-header", this.Header())
        .Attribute("data-show-border", this.Border())
        .Attribute("data-show-faces", this.Faces())
        .Attribute("data-stream", this.Stream())
        .CssClass("fb-like-box")
        .ToString();
    }
  }
}