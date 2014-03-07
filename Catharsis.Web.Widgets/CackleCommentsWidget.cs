using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle comments widget for registered website.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://ru.cackle.me/help/widget-api"/>
  public sealed class CackleCommentsWidget : HtmlWidgetBase<ICackleCommentsWidget>, ICackleCommentsWidget
  {
    private string account;

    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <remarks>This attribute is required.</remarks>
    public ICackleCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (account.IsEmpty())
      {
        return;
      }

      var config = new { widget = "Comment", id = this.account };

      writer.Write(@"<div id=""mc-container""></div>");
      writer.Write(this.JavaScript("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatSelf(config.Json())));
      writer.Write(@"<a id=""mc-link"" href=""http://cackle.me"">Социальные комментарии <b style=""color:#4FA3DA"">Cackl</b><b style=""color:#F65077"">e</b></a>");
    }
  }
}