using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalRepostButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalRepostButtonWidgetTests : ClassTest<LiveJournalRepostButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="LiveJournalRepostButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(LiveJournalRepostButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ILiveJournalRepostButtonWidget>();

    var widget = new LiveJournalRepostButtonWidget();
    widget.Text().Should().BeNull();
    widget.Title().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new LiveJournalRepostButtonWidget().Text(null));
    Assert.Throws<ArgumentException>(() => new LiveJournalRepostButtonWidget().Text(string.Empty));

    using (new AssertionScope())
    {
      var widget = new LiveJournalRepostButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string text, ILiveJournalRepostButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new LiveJournalRepostButtonWidget().Title(null));
    Assert.Throws<ArgumentException>(() => new LiveJournalRepostButtonWidget().Title(string.Empty));

    using (new AssertionScope())
    {
      var widget = new LiveJournalRepostButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string title, ILiveJournalRepostButtonWidget widget)
    {
      widget.Title(title).Should().BeSameAs(widget);
      widget.Title().Should().Be(title);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("<lj-repost></lj-repost>", new LiveJournalRepostButtonWidget().ToString());
    Assert.Equal("""<lj-repost button="title"></lj-repost>""", new LiveJournalRepostButtonWidget().Title("title").ToString());
    Assert.Equal("""<lj-repost button="title">text</lj-repost>""", new LiveJournalRepostButtonWidget().Title("title").Text("text").ToString());
  }
}