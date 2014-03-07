using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class CackleCommentsWidget : HtmlWidgetBase<ICackleCommentsWidget>, ICackleCommentsWidget
  {
    private string account;

    public ICackleCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

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