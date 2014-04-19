using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders SoundCloud user's profile icon.</para>
  /// </summary>
  /// <seealso cref="https://soundcloud.com/pages/embed"/>
  public class SoundCloudProfileIconWidget : HtmlWidgetBase, ISoundCloudProfileIconWidget
  {
    private string account;
    private string color = "orange_white";
    private short size = (short) SoundCloudProfileIconSize.Size32;

    /// <summary>
    ///   <para>SoundCloud user's account name.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public ISoundCloudProfileIconWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Color of profile icon.</para>
    /// </summary>
    /// <param name="color">Icon's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public ISoundCloudProfileIconWidget Color(string color)
    {
      Assertion.NotEmpty(color);

      this.color = color;
      return this;
    }

    /// <summary>
    ///   <para>Edge size of profile icon in pixels.</para>
    /// </summary>
    /// <param name="size">Icon's size.</param>
    /// <returns>Reference to the current widget.</returns>
    public ISoundCloudProfileIconWidget Size(short size)
    {
      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("allowtransparency", true)
        .Attribute("frameborder", 0)
        .Attribute("scrolling", "no")
        .Attribute("style", "width: {0}px; height: {0}px;".FormatSelf(this.size))
        .Attribute("src", "https://w.soundcloud.com/icon/?url={0}".FormatSelf("http://soundcloud.com/{0}&color={1}&size={2}".FormatSelf(this.account, this.color, this.size)))
        .ToString();
    }
  }
}