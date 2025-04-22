using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalRepostButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalRepostButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="LiveJournalRepostButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(LiveJournalRepostButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ILiveJournalRepostButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new LiveJournalRepostButtonWidget();
      widget.GetPropertyValue<string>("TextProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TitleProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new LiveJournalRepostButtonWidget().Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("text");
      AssertionExtensions.Should(() => new LiveJournalRepostButtonWidget().Text(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("text");

      new LiveJournalRepostButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string text, ILiveJournalRepostButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new LiveJournalRepostButtonWidget().Title(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new LiveJournalRepostButtonWidget().Title(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new LiveJournalRepostButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string title, ILiveJournalRepostButtonWidget widget) => widget.Title(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleProperty").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new LiveJournalRepostButtonWidget(), "<lj-repost></lj-repost>");
      Validate(new LiveJournalRepostButtonWidget().Title("title"), """<lj-repost button="title"></lj-repost>""");
      Validate(new LiveJournalRepostButtonWidget().Title("title").Text("text"), """<lj-repost button="title">text</lj-repost>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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