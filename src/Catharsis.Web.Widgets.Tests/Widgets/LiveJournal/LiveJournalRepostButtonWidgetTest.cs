using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalRepostButtonWidget"/>.</para>
/// </summary>
public sealed class LiveJournalRepostButtonWidgetTest : Test
{
  private ILiveJournalRepostButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public LiveJournalRepostButtonWidgetTest() => Widget = Fixture<ILiveJournalRepostButtonWidget>.Create();

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
      widget.GetPropertyValue<string>("TextValue").Should().BeNull();
      widget.GetPropertyValue<string>("TitleValue").Should().BeNull();
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string text, ILiveJournalRepostButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextValue").Should().Be(text);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string title, ILiveJournalRepostButtonWidget widget) => widget.Title(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleValue").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new LiveJournalRepostButtonWidget());
      Test(Fixture<LiveJournalRepostButtonWidget>.Create());
    }

    return;

    static void Test(ILiveJournalRepostButtonWidget original)
    {
      var clone = original.Clone<ILiveJournalRepostButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalRepostButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new LiveJournalRepostButtonWidget(), "<lj-repost></lj-repost>");
      Test(new LiveJournalRepostButtonWidget().Title("title"), """<lj-repost button="title"></lj-repost>""");
      Test(new LiveJournalRepostButtonWidget().Title("title").Text("text"), """<lj-repost button="title">text</lj-repost>""");
      Test(Fixture<LiveJournalRepostButtonWidget>.Create());
    }

    return;

    static void Test(ILiveJournalRepostButtonWidget widget, params string[] html)
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