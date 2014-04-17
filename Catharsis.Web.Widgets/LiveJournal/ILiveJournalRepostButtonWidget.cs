using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders LiveJournal "Repost" button.</para>
  /// </summary>
  /// <seealso cref="http://www.livejournal.com/support/faq/313.html"/>
  public interface ILiveJournalRepostButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Text fragment to be reposted.</para>
    /// </summary>
    /// <param name="text">Text fragment.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    ILiveJournalRepostButtonWidget Text(string text);

    /// <summary>
    ///   <para>Label text to display on the button.</para>
    /// </summary>
    /// <param name="title">Button's label text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    ILiveJournalRepostButtonWidget Title(string title);
  }
} 