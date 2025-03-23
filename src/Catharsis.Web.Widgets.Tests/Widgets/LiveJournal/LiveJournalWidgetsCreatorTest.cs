using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalWidgetsCreator"/>.</para>
/// </summary>
public sealed class LiveJournalWidgetsCreatorTest : UnitTest
{
  private ILiveJournalWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.LiveJournal();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="LiveJournalWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(LiveJournalWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ILiveJournalWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Widgets.LikeButton().Should().BeOfType<LiveJournalLikeButtonWidget>().And.NotBeSameAs(Widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.RepostButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void RepostButton_Method()
  {
    Widgets.RepostButton().Should().BeOfType<LiveJournalRepostButtonWidget>().And.NotBeSameAs(Widgets.RepostButton());
  }
}