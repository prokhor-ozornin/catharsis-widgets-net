using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook "Send" button.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/send-button"/>
  public sealed class FacebookSendButtonWidget : HtmlWidgetBase<IFacebookSendButtonWidget>, IFacebookSendButtonWidget
  {
    private string url;
    private string width;
    private string height;
    private string colorScheme;
    private bool? kids;
    private string trackLabel;

    /// <summary>
    ///   <para>The absolute URL of the page that will be sent. Default is current page URL.</para>
    /// </summary>
    /// <param name="url">URL of the page to send.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>The width of the button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>The height of the button.</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>The color scheme used by the button. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    /// <summary>
    ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="kids"><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookSendButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="trackLabel">>Label to track referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="trackLabel"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="trackLabel"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget TrackLabel(string trackLabel)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = trackLabel;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .Attribute("data-ref", this.trackLabel)
        .AddCssClass("fb-send")));
    }
  }
}