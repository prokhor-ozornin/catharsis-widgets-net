using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders LiveJournal "Repost" button.</para>
  /// </summary>
  /// <seealso cref="http://www.livejournal.com/support/faq/313.html"/>
  public class LiveJournalRepostButtonWidget : HtmlWidget, ILiveJournalRepostButtonWidget
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
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Text fragment to be reposted.</para>
    /// </summary>
    /// <returns>Text fragment.</returns>
    public string Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Label text to display on the button.</para>
    /// </summary>
    /// <param name="title">Button's label text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    public ILiveJournalRepostButtonWidget Title(string title)
    {
      Assertion.NotEmpty(title);

      this.title = title;
      return this;
    }

    /// <summary>
    ///   <para>Label text to display on the button.</para>
    /// </summary>
    /// <returns>Button's label text.</returns>
    public string Title()
    {
      return this.title;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return new TagBuilder("lj-repost")
       .Attribute("button", this.Title())
       .InnerHtml(this.text)
       .ToString();
    }
  }
}