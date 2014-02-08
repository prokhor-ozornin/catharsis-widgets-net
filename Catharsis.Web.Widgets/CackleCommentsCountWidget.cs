using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle comments widget for registered website.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  ///   <seealso cref="http://ru.cackle.me/help/widget-api"/>
  /// </summary>
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
      writer.Write(this.JavaScript("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatValue(config.Json())));
    }
  }
}