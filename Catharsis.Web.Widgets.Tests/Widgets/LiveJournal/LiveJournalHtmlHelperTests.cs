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
    ///   <para>Performs testing of <see cref="LiveJournalHtmlHelper.Like()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.LiveJournal().Like(), this.html.LiveJournal().Like()));
      Assert.True(this.html.LiveJournal().Like() is LiveJournalLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="LiveJournalHtmlHelper.Repost()"/> method.</para>
    /// </summary>
    [Fact]
    public void Repost_Method()
    {
      Assert.False(ReferenceEquals(this.html.LiveJournal().Like(), this.html.LiveJournal().Like()));
      Assert.True(this.html.LiveJournal().Like() is LiveJournalLikeButtonWidget);
    }
  }
}