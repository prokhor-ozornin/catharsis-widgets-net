namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalLikeButtonWidget"/>
public class LiveJournalLikeButtonWidget : HtmlWidget, ILiveJournalLikeButtonWidget
{
  private const string html = @"<lj-like buttons=""repost""/>";

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => html;
}