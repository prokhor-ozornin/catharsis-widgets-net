using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalLikeButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalLikeButtonWidgetTests : ClassTest<LiveJournalLikeButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<lj-like buttons="repost"/>""", new LiveJournalLikeButtonWidget().ToString());
  }
}