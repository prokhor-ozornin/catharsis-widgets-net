using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="LiveJournalLikeButtonWidget"/>.</para>
  /// </summary>
  public sealed class LiveJournalLikeButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="LiveJournalLikeButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<lj-like buttons=""repost""/>", new LiveJournalLikeButtonWidget().ToString());
    }
  }
}