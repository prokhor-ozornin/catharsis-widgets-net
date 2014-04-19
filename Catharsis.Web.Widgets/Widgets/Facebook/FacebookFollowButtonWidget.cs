using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook "Follow" button.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/follow-button"/>
  public class FacebookFollowButtonWidget : HtmlWidgetBase, IFacebookFollowButtonWidget
  {
    private string colorScheme;
    private bool? faces;
    private string height;
    private bool? kids;
    private string layout;
    private string url;
    private string width;

    /// <summary>
    ///   <para>The color scheme used by the button. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFollowButtonWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    /// <summary>
    ///   <para>Specifies whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites.</para>
    /// </summary>
    /// <param name="faces"><c>true</c> to show profiles photos, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookFollowButtonWidget Faces(bool faces = true)
    {
      this.faces = faces;
      return this;
    }

    /// <summary>
    ///   <para>The height of the button.</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFollowButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="kids"><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookFollowButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button. Default is "standard".</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFollowButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>The Facebook.com profile URL of the user to follow.</para>
    /// </summary>
    /// <param name="url">Profile URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookFollowButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookFollowButtonWidget Width(string width)
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
      if (this.url.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("div")
        .Attribute("data-layout", this.layout)
        .Attribute("data-show-faces", this.faces)
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .CssClass("fb-follow")
        .ToString();
    }
  }
}