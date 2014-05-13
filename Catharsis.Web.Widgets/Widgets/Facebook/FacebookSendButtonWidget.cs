using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook "Send" button.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/send-button"/>
  public class FacebookSendButtonWidget : HtmlWidget, IFacebookSendButtonWidget
  {
    private string url;
    private string width;
    private string height;
    private string colorScheme;
    private bool? kidsMode;
    private string trackLabel;

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
    ///   <para>The color scheme used by the button. Default is "light".</para>
    /// </summary>
    /// <returns>Color scheme of button.</returns>
    public string ColorScheme()
    {
      return this.colorScheme;
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
    ///   <para>The height of the button.</para>
    /// </summary>
    /// <returns>Height of button.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookSendButtonWidget KidsMode(bool enabled)
    {
      this.kidsMode = enabled;
      return this;
    }

    /// <summary>
    ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</returns>
    public bool? KidsMode()
    {
      return this.kidsMode;
    }

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="label">Label to track referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookSendButtonWidget TrackLabel(string label)
    {
      Assertion.NotEmpty(label);

      this.trackLabel = label;
      return this;
    }

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <returns>Label to track referrals.</returns>
    public string TrackLabel()
    {
      return this.trackLabel;
    }

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
    ///   <para>The absolute URL of the page that will be sent. Default is current page URL.</para>
    /// </summary>
    /// <returns>URL of the page to send.</returns>
    public string Url()
    {
      return this.url;
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
    ///   <para>The width of the button.</para>
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
      return new TagBuilder("div")
        .Attribute("data-href", this.Url())
        .Attribute("data-colorscheme", this.ColorScheme())
        .Attribute("data-kid-directed-site", this.KidsMode())
        .Attribute("data-width", this.Width())
        .Attribute("data-height", this.Height())
        .Attribute("data-ref", this.TrackLabel())
        .CssClass("fb-send")
        .ToString();
    }
  }
}