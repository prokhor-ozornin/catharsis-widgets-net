using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook comments widget.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/comments"/>
  public class FacebookCommentsWidget : HtmlWidget, IFacebookCommentsWidget
  {
    private string colorScheme;
    private bool? mobile;
    private string order;
    private byte? posts;
    private string url;
    private string width;

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookCommentsWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <returns>Color scheme of widget.</returns>
    public string ColorScheme()
    {
      return this.colorScheme;
    }

    /// <summary>
    ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
    /// </summary>
    /// <param name="mobile"><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookCommentsWidget Mobile(bool mobile)
    {
      this.mobile = mobile;
      return this;
    }

    /// <summary>
    ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
    /// </summary>
    /// <returns><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</returns>
    public bool? Mobile()
    {
      return this.mobile;
    }

    /// <summary>
    ///   <para>The order to use when displaying comments.</para>
    /// </summary>
    /// <param name="order">Order of comments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="order"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="order"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookCommentsWidget Order(string order)
    {
      Assertion.NotEmpty(order);

      this.order = order;
      return this;
    }

    /// <summary>
    ///   <para>The order to use when displaying comments.</para>
    /// </summary>
    /// <returns>Order of comments.</returns>
    public string Order()
    {
      return this.order;
    }

    /// <summary>
    ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
    /// </summary>
    /// <param name="posts">Number of comments to show.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookCommentsWidget Posts(byte posts)
    {
      this.posts = posts;
      return this;
    }

    /// <summary>
    ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
    /// </summary>
    /// <returns>Number of comments to show.</returns>
    public byte? Posts()
    {
      return this.posts;
    }

    /// <summary>
    ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
    /// </summary>
    /// <param name="url">URL of the page for comments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookCommentsWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
    /// </summary>
    /// <returns>URL of the page for comments.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookCommentsWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
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
        .Attribute("data-href", this.Url())
        .Attribute("data-num-posts", this.Posts())
        .Attribute("data-width", this.Width())
        .Attribute("data-colorscheme", this.ColorScheme())
        .Attribute("data-mobile", this.Mobile())
        .Attribute("data-order-by", this.Order())
        .CssClass("fb-comments")
        .ToString();
    }
  }
}