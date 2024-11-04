using System;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle comments widget for registered website.</para>
  ///   <para>Requires Cackle scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://ru.cackle.me/help/widget-api"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Cackle(IWidgetsScriptsRenderer)"/>
  public class CackleCommentsWidget : HtmlWidget, ICackleCommentsWidget
  {
    private string account;

    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public ICackleCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <returns>Identifier of website.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (account.IsEmpty())
      {
        return string.Empty;
      }

      var config = new
      {
        widget = "Comment",
        id = this.Account()
      };

      return new StringBuilder()
        .Append(@"<div id=""mc-container""></div>")
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatSelf(config.Json())))
        .Append(@"<a id=""mc-link"" href=""http://cackle.me"">Социальные комментарии <b style=""color:#4FA3DA"">Cackl</b><b style=""color:#F65077"">e</b></a>")
        .ToString();
    }
  }
}