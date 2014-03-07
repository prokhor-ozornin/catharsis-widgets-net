using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class CackleCommentsCountWidget : HtmlWidgetBase<ICackleCommentsCountWidget>, ICackleCommentsCountWidget
  {
    private string account;

    public ICackleCommentsCountWidget Account(string account)
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

      var config = new { widget = "CommentCount", id = this.account };
      writer.Write(this.JavaScript("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatSelf(config.Json())));
    }
  }
}