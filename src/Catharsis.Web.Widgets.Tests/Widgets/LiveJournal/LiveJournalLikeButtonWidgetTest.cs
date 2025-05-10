using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalLikeButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalLikeButtonWidgetTest : Test
{
  private ILiveJournalLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public LiveJournalLikeButtonWidgetTest() => Widget = Fixture.Create<ILiveJournalLikeButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new LiveJournalLikeButtonWidget());
      Test(Fixture.Create<LiveJournalLikeButtonWidget>());
    }

    return;

    static void Test(ILiveJournalLikeButtonWidget original)
    {
      var clone = original.Clone<ILiveJournalLikeButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new LiveJournalLikeButtonWidget(), """<lj-like buttons="repost"/>""");
      Test(Fixture.Create<LiveJournalLikeButtonWidget>());
    }

    return;

    static void Test(ILiveJournalLikeButtonWidget widget, params string[] html)
    {
      if (html.IsUnset())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}