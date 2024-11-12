using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="LiveJournalHtmlHelper"/>.</para>
  /// </summary>
  public sealed class LiveJournalHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="LiveJournalHtmlHelper.LikeButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.LiveJournal().LikeButton(), this.html.LiveJournal().LikeButton()));
      Assert.True(this.html.LiveJournal().LikeButton() is LiveJournalLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="LiveJournalHtmlHelper.RepostButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void RepostButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.LiveJournal().RepostButton(), this.html.LiveJournal().RepostButton()));
      Assert.True(this.html.LiveJournal().RepostButton() is LiveJournalRepostButtonWidget);
    }
  }
}