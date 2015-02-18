using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Facepile widget.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/facepile"/>
  public class FacebookFacepileWidget : HtmlWidget, IFacebookFacepileWidget
  {
    private IEnumerable<string> actions = Enumerable.Empty<string>();
    private string colorScheme;
    private string height;
    private byte? maxRows;
    private string photoSize;
    private string url;
    private string width;

    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
    public IFacebookFacepileWidget Actions(IEnumerable<string> actions)
    {
      Assertion.NotNull(actions);

      this.actions = actions;
      return this;
    }

    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <returns>Collection of Facebook action types.</returns>
    public IEnumerable<string> Actions()
    {
      return this.actions;
    }

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFacepileWidget ColorScheme(string colorScheme)
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
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFacepileWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>The maximum number of rows of faces to display. Default is 1.</para>
    /// </summary>
    /// <param name="maxRows">Number of rows of faces to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookFacepileWidget MaxRows(byte maxRows)
    {
      this.maxRows = maxRows;
      return this;
    }

    /// <summary>
    ///   <para>The maximum number of rows of faces to display. Default is 1.</para>
    /// </summary>
    /// <returns>Number of rows of faces to display.</returns>
    public byte? MaxRows()
    {
      return this.maxRows;
    }

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of photos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFacepileWidget PhotoSize(string size)
    {
      Assertion.NotEmpty(size);

      this.photoSize = size;
      return this;
    }

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget. Default is "medium".</para>
    /// </summary>
    /// <returns>Size of photos.</returns>
    public string PhotoSize()
    {
      return this.photoSize;
    }

    /// <summary>
    ///   <para>Display photos of the people who have liked this absolute URL. Default is current page URL.</para>
    /// </summary>
    /// <param name="url">Target "liked" URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFacepileWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>Display photos of the people who have liked this absolute URL. Default is current page URL.</para>
    /// </summary>
    /// <returns>Target "liked" URL.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 200. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFacepileWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 200. Default is 300.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
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
      return new TagBuilder("div")
        .Attribute("data-href", this.Url() ?? (HttpContext.Current != null ? HttpContext.Current.Request.Url.ToString() : null))
        .Attribute("data-action", this.Actions().Any() ? this.Actions().Join(",") : null)
        .Attribute("data-size", this.PhotoSize())
        .Attribute("data-width", this.Width())
        .Attribute("data-height", this.Height())
        .Attribute("data-max-rows", this.MaxRows())
        .Attribute("data-colorscheme", this.ColorScheme())
        .CssClass("fb-facepile")
        .ToString();
    }
  }
}