using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLatestCommentsWidget"/>
public class CackleLatestCommentsWidget : WebWidget, ICackleLatestCommentsWidget
{
  private string account;
  private short avatarSize = 32;
  private byte max = 5;
  private int textSize = 150;
  private int titleSize = 40;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account(string)"/>
  public ICackleLatestCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize(short)"/>
  public ICackleLatestCommentsWidget AvatarSize(short size)
  {
    avatarSize = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize()"/>
  public short AvatarSize() => avatarSize;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max(byte)"/>
  public ICackleLatestCommentsWidget Max(byte max)
  {
    this.max = max;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max()"/>
  public byte Max() => max;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize(int)"/>
  public ICackleLatestCommentsWidget TextSize(int size)
  {
    textSize = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize()"/>
  public int TextSize() => textSize;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize(int)"/>
  public ICackleLatestCommentsWidget TitleSize(int size)
  {
    titleSize = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize()"/>
  public int TitleSize() => titleSize;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (account.IsEmpty())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "CommentRecent",
      id = Account(),
      size = Max(),
      avatarSize = AvatarSize(),
      textSize = TextSize(),
      titleSize = TitleSize()
    };

    return new StringBuilder()
      .Append(@"<div id=""mc-last""></div>")
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()});"))
      .Append(@"<a id=""mc-link"" href=""http://cackle.me"">���������� ����������� <b style=""color:#4FA3DA"">Cackl</b><b style=""color:#F65077"">e</b></a>")
      .ToString();
  }
}