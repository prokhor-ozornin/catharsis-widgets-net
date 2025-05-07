using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalRepostButtonWidget"/>
public class LiveJournalRepostButtonWidget : WebWidget, ILiveJournalRepostButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleValue { get; set; }

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Text(string)"/>
  public virtual ILiveJournalRepostButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Title(string)"/>
  public virtual ILiveJournalRepostButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleValue = title;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new LiveJournalRepostButtonWidget
  {
    TextValue = TextValue,
    TitleValue = TitleValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("lj-repost")
    .Attribute("button", TitleValue)
    .Html(TextValue)
    .ToString();
}