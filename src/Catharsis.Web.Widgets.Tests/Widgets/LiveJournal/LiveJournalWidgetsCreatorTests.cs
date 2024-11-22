using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalWidgetsCreator"/>.</para>
/// </summary>
public sealed class LiveJournalWidgetsCreatorTests : ClassTest<LiveJournalWidgetsCreator>
{
  private readonly ILiveJournalWidgetsCreator widgets = Widgets.Web.LiveJournal();

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    widgets.LikeButton().Should().BeOfType<LiveJournalLikeButtonWidget>().And.NotBeSameAs(widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.RepostButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void RepostButton_Method()
  {
    widgets.RepostButton().Should().BeOfType<LiveJournalRepostButtonWidget>().And.NotBeSameAs(widgets.RepostButton());
  }
}