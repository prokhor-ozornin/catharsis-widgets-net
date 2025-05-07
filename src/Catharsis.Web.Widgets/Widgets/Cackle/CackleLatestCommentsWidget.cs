using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLatestCommentsWidget"/>
public class CackleLatestCommentsWidget : WebWidget, ICackleLatestCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short AvatarSizeValue { get; set; } = 32;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte MaxValue { get; set; } = 5;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual int TextSizeValue { get; set; } = 150;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual int TitleSizeValue { get; set; } = 40;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account(string)"/>
  public virtual ICackleLatestCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize(short)"/>
  public virtual ICackleLatestCommentsWidget AvatarSize(short size)
  {
    AvatarSizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max(byte)"/>
  public virtual ICackleLatestCommentsWidget Max(byte count)
  {
    MaxValue = count;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize(int)"/>
  public virtual ICackleLatestCommentsWidget TextSize(int size)
  {
    TextSizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize(int)"/>
  public virtual ICackleLatestCommentsWidget TitleSize(int size)
  {
    TitleSizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new CackleLatestCommentsWidget
  {
    AccountValue = AccountValue,
    AvatarSizeValue = AvatarSizeValue,
    MaxValue = MaxValue,
    TextSizeValue = TextSizeValue,
    TitleSizeValue = TitleSizeValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "CommentRecent",
      id = AccountValue,
      size = MaxValue,
      avatarSize = AvatarSizeValue,
      textSize = TextSizeValue,
      titleSize = TitleSizeValue
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