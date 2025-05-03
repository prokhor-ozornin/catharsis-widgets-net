using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalLikeButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalLikeButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new LiveJournalLikeButtonWidget());
      Validate(Attributes.LiveJournalLikeButtonWidget());
    }

    return;

    static void Validate(ILiveJournalLikeButtonWidget original)
    {
      var clone = original.Clone<ILiveJournalLikeButtonWidget>();

      clone.Id.Should().Be(original.Id);
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
      Validate(new LiveJournalLikeButtonWidget(), """<lj-like buttons="repost"/>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
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