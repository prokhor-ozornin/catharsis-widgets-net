using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalRepostButtonWidget"/>
public class LiveJournalRepostButtonWidget : WebWidget, ILiveJournalRepostButtonWidget
{
  private string text;
  private string title;

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Text(string)"/>
  public ILiveJournalRepostButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    this.text = text;
    return this;
  }

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Text()"/>
  public string Text() => text;

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Title(string)"/>
  public ILiveJournalRepostButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    this.title = title;
    return this;
  }

  /// <inheritdoc cref="ILiveJournalRepostButtonWidget.Title()"/>
  public string Title() => title;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("lj-repost")
    .Attribute("button", Title())
    .InnerHtml(text)
    .ToString();
}