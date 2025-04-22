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
  protected virtual string AccountProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short AvatarSizeProperty { get; set; } = 32;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte MaxProperty { get; set; } = 5;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual int TextSizeProperty { get; set; } = 150;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual int TitleSizeProperty { get; set; } = 40;

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Account(string)"/>
  public virtual ICackleLatestCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.AvatarSize(short)"/>
  public virtual ICackleLatestCommentsWidget AvatarSize(short size)
  {
    AvatarSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.Max(byte)"/>
  public virtual ICackleLatestCommentsWidget Max(byte count)
  {
    MaxProperty = count;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TextSize(int)"/>
  public virtual ICackleLatestCommentsWidget TextSize(int size)
  {
    TextSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ICackleLatestCommentsWidget.TitleSize(int)"/>
  public virtual ICackleLatestCommentsWidget TitleSize(int size)
  {
    TitleSizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "CommentRecent",
      id = AccountProperty,
      size = MaxProperty,
      avatarSize = AvatarSizeProperty,
      textSize = TextSizeProperty,
      titleSize = TitleSizeProperty
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