using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalWidgetsCreator"/>.</para>
/// </summary>
public sealed class LiveJournalWidgetsCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.LiveJournal().LikeButton(), this.html.LiveJournal().LikeButton()));
    Assert.True(this.html.LiveJournal().LikeButton() is LiveJournalLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.RepostButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void RepostButton_Method()
  {
    Assert.False(ReferenceEquals(this.html.LiveJournal().RepostButton(), this.html.LiveJournal().RepostButton()));
    Assert.True(this.html.LiveJournal().RepostButton() is LiveJournalRepostButtonWidget);
  }
}