using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalRepostButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalRepostButtonWidgetTests
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

    var widget = new LiveJournalRepostButtonWidget();
    Assert.Null(widget.Text());
    Assert.True(ReferenceEquals(widget.Text("text"), widget));
    Assert.Equal("text", widget.Text());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new LiveJournalRepostButtonWidget().Title(null));
    Assert.Throws<ArgumentException>(() => new LiveJournalRepostButtonWidget().Title(string.Empty));

    var widget = new LiveJournalRepostButtonWidget();
    Assert.Null(widget.Title());
    Assert.True(ReferenceEquals(widget.Title("title"), widget));
    Assert.Equal("title", widget.Title());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.ToHtml"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtmlString_Method()
  {
    Assert.Equal(@"<lj-repost></lj-repost>", new LiveJournalRepostButtonWidget().ToString());
    Assert.Equal(@"<lj-repost button=""title""></lj-repost>", new LiveJournalRepostButtonWidget().Title("title").ToString());
    Assert.Equal(@"<lj-repost button=""title"">text</lj-repost>", new LiveJournalRepostButtonWidget().Title("title").Text("text").ToString());
  }
}