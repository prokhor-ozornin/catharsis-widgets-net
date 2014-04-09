using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Tumblr "Follow" button.</para>
  ///   <para>Requires <see cref="WidgetsScripts.TumblrShare"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.tumblr.com/buttons"/>
  public sealed class TumblrFollowButtonWidget : HtmlWidgetBase, ITumblrFollowButtonWidget
  {
    private string account;
    private byte type = (byte) TumblrFollowButtonType.First;
    private string colorScheme = TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant();

    /// <summary>
    ///   <para>Name of Tumblr account (blog).</para>
    /// </summary>
    /// <param name="account">Name of blog.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public ITumblrFollowButtonWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    public ITumblrFollowButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITumblrFollowButtonWidget Type(byte type)
    {
      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      byte width = 189;
      switch ((TumblrFollowButtonType) this.type)
      {
        case TumblrFollowButtonType.Second :
          width = 113;
        break;

        case TumblrFollowButtonType.Third :
          width = 18;
        break;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("border", 0)
        .Attribute("allowtransparency", true)
        .Attribute("src", "http://platform.tumblr.com/v1/follow_button.html?button_type={1}&tumblelog={0}&color_scheme={2}".FormatSelf(this.account, this.type, this.colorScheme))
        .Attribute("frameborder", 0)
        .Attribute("height", 25)
        .Attribute("scrolling", "no")
        .Attribute("width", width)
        .AddCssClass("btn")));
    }
  }
}