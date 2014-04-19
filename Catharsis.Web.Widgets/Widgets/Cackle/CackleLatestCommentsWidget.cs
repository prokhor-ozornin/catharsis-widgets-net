using System;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle latest comments widget for registered website.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://ru.cackle.me/help/widget-api"/>
  public class CackleLatestCommentsWidget : HtmlWidgetBase, ICackleLatestCommentsWidget
  {
    private string account;
    private short? avatarSize;
    private byte? max;
    private int? textSize;
    private int? titleSize;

    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public ICackleLatestCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Size of user avatars. Default is 32.</para>
    /// </summary>
    /// <param name="size">Size of user avatars.</param>
    /// <returns>Reference to the current widget.</returns>
    public ICackleLatestCommentsWidget AvatarSize(short size)
    {
      this.avatarSize = size;
      return this;
    }

    /// <summary>
    ///   <para>Number of comments to display. Maximum 100, default 5.</para>
    /// </summary>
    /// <param name="max">Number of comments to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public ICackleLatestCommentsWidget Max(byte max)
    {
      this.max = max;
      return this;
    }

    /// <summary>
    ///   <para>Maximum allowed count of characters in comment (0 - do not cut). Default is 150.</para>
    /// </summary>
    /// <param name="size">Maximum count of characters in comment.</param>
    /// <returns>Reference to the current widget.</returns>
    public ICackleLatestCommentsWidget TextSize(int size)
    {
      this.textSize = size;
      return this;
    }

    /// <summary>
    ///   <para>Maximum allowed count of characters in title (0 - do not cut). Default is 40.</para>
    /// </summary>
    /// <param name="size">Maximum count of characters in title.</param>
    /// <returns>Reference to the current widget.</returns>
    public ICackleLatestCommentsWidget TitleSize(int size)
    {
      this.titleSize = size;
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

      var config = new
      {
        widget = "CommentRecent",
        id = this.account,
        size = this.max.GetValueOrDefault(5),
        avatarSize = this.avatarSize.GetValueOrDefault(32),
        textSize = this.textSize.GetValueOrDefault(150),
        titleSize = this.titleSize.GetValueOrDefault(40)
      };

      return new StringBuilder()
        .Append(@"<div id=""mc-last""></div>")
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatSelf(config.Json())))
        .Append(@"<a id=""mc-link"" href=""http://cackle.me"">Социальные комментарии <b style=""color:#4FA3DA"">Cackl</b><b style=""color:#F65077"">e</b></a>")
        .ToString();
    }
  }
}