namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders LiveJournal "Like" button.</para>
  /// </summary>
  public class LiveJournalLikeButtonWidget : HtmlWidget, ILiveJournalLikeButtonWidget
  {
    private const string html = @"<lj-like buttons=""repost""/>";

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return html;
    }
  }
}