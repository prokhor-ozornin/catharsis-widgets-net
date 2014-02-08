using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class CackleLatestCommentsWidget : HtmlWidgetBase<ICackleLatestCommentsWidget>, ICackleLatestCommentsWidget
  {
    private string account;
    private byte? max;
    private int? textSize;
    private int? titleSize;
    private short? avatarSize;

    public ICackleLatestCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public ICackleLatestCommentsWidget Max(byte max)
    {
      this.max = max;
      return this;
    }

    public ICackleLatestCommentsWidget TextSize(int size)
    {
      this.textSize = size;
      return this;
    }

    public ICackleLatestCommentsWidget TitleSize(int size)
    {
      this.titleSize = size;
      return this;
    }

    public ICackleLatestCommentsWidget AvatarSize(short size)
    {
      this.avatarSize = size;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
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

      writer.Write(@"<div id=""mc-last""></div>");
      writer.Write(this.JavaScript("cackle_widget = window.cackle_widget || [];cackle_widget.push({0});".FormatValue(config.Json())));
      writer.Write(@"<a id=""mc-link"" href=""http://cackle.me"">Социальные комментарии <b style=""color:#4FA3DA"">Cackl</b><b style=""color:#F65077"">e</b></a>");
    }
  }
}