using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class CackleLoginWidget : HtmlWidgetBase<ICackleLoginWidget>, ICackleLoginWidget
  {
    private string account;

    public ICackleLoginWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      var config = new { widget = "Login", id = this.account };

      writer.Write(@"<div id=""mc-login""></div>");
      writer.Write(this.JavaScript("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatValue(config.Json())));
    }
  }
}