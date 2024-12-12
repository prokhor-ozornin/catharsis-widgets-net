namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalLikeButtonWidget"/>
public class LiveJournalLikeButtonWidget : WebWidget, ILiveJournalLikeButtonWidget
{
  private const string html = """<lj-like buttons="repost"/>""";

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => html;
}