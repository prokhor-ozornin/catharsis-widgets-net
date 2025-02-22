using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLatestCommentsWidget"/>
public class CackleLatestCommentsWidget : WebWidget, ICackleLatestCommentsWidget
{
  private string AccountProperty { get; set; }
  private short AvatarSizeProperty { get; set; } = 32;
  private byte MaxProperty { get; set; } = 5;
  private int TextSizeProperty { get; set; } = 150;
  private int TitleSizeProperty { get; set; } = 40;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account(string)"/>
  public ICackleLatestCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize(short)"/>
  public ICackleLatestCommentsWidget AvatarSize(short size)
  {
    AvatarSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize()"/>
  public short AvatarSize() => AvatarSizeProperty;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max(byte)"/>
  public ICackleLatestCommentsWidget Max(byte count)
  {
    MaxProperty = count;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max()"/>
  public byte Max() => MaxProperty;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize(int)"/>
  public ICackleLatestCommentsWidget TextSize(int size)
  {
    TextSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize()"/>
  public int TextSize() => TextSizeProperty;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize(int)"/>
  public ICackleLatestCommentsWidget TitleSize(int size)
  {
    TitleSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize()"/>
  public int TitleSize() => TitleSizeProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsEmpty())
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
      .Append("""<div id="mc-last"></div>""")
      .Append(new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .Html($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()});")
      )
      .Append("""<a id="mc-link" href="http://cackle.me">���������� ����������� <b style="color:#4FA3DA">Cackl</b><b style="color:#F65077">e</b></a>""")
      .ToString();
  }
}