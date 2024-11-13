using System.Web.Mvc;
using System.Web.WebPages;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalRepostButtonWidget"/>
public class LiveJournalRepostButtonWidget : WebWidget, ILiveJournalRepostButtonWidget
{
  private string text;
  private string title;

  /// <summary>
  ///   <para>Text fragment to be reposted.</para>
  /// </summary>
  /// <param name="text">Text fragment.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
  public ILiveJournalRepostButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    this.text = text;
    return this;
  }

  /// <summary>
  ///   <para>Text fragment to be reposted.</para>
  /// </summary>
  /// <returns>Text fragment.</returns>
  public string Text() => text;

  /// <summary>
  ///   <para>Label text to display on the button.</para>
  /// </summary>
  /// <param name="title">Button's label text.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
  public ILiveJournalRepostButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    this.title = title;
    return this;
  }

  /// <summary>
  ///   <para>Label text to display on the button.</para>
  /// </summary>
  /// <returns>Button's label text.</returns>
  public string Title() => title;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("lj-repost")
    .Attribute("button", Title())
    .InnerHtml(text)
    .ToString();
}