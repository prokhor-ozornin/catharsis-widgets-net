namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing LiveJournal widgets.</para>
  /// </summary>
  public interface ILiveJournalHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new LiveJournal "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ILiveJournalLikeButtonWidget Like();

    /// <summary>
    ///   <para>Creates new LiveJournal "Repost" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ILiveJournalRepostButtonWidget Repost();
  }
}