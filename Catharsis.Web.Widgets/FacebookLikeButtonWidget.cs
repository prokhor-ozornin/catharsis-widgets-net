using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook "Like"/"Recommend" button.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/like-button"/>
  public sealed class FacebookLikeButtonWidget : HtmlWidgetBase<IFacebookLikeButtonWidget>, IFacebookLikeButtonWidget
  {
    private string verb;
    private string colorScheme;
    private string url;
    private bool? kids;
    private string layout;
    private string trackLabel;
    private bool? faces;
    private string width;

    /// <summary>
    ///   <para>The verb to display on the button. Default is "like".</para>
    /// </summary>
    /// <param name="verb">Verb on the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="verb"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="verb"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeButtonWidget Verb(string verb)
    {
      Assertion.NotEmpty(verb);

      this.verb = verb;
      return this;
    }

    /// <summary>
    ///   <para>Color scheme used by the button. Default is "light".</para>
    /// </summary>
    /// <param name="scheme">The color scheme for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    /// <summary>
    ///   <para>Specifies absolute URL of the page that will be liked.</para>
    /// </summary>
    /// <param name="url">URL of the page to "like".</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookLikeButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="kids"><c>true</c> if site is directed to small children, <c>false</c> otherwise.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    /// <summary>
    ///   <para>One of the different layouts that are available for the button. Default is "standard".</para>
    /// </summary>
    /// <param name="layout">Button layout.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="label">Label to track referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeButtonWidget TrackLabel(string label)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = label;
      return this;
    }

    /// <summary>
    ///   <para>Whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="faces"><c>true</c> to display profile photos, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookLikeButtonWidget Faces(bool faces = true)
    {
      this.faces = faces;
      return this;
    }

    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookLikeButtonWidget Width(string width)
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

      if (this.url.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-action", this.verb)
        .Attribute("data-layout", this.layout)
        .Attribute("data-show-faces", this.faces)
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-ref", this.trackLabel)
        .Attribute("data-width", this.width)
        .AddCssClass("fb-like")));
    }
  }
}