using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterFollowButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="TwitterFollowButtonWidget"/>
public sealed class TwitterFollowButtonWidgetTest : Test
{
  private ITwitterFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public TwitterFollowButtonWidgetTest() => Widget = Fixture<ITwitterFollowButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TwitterFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITwitterFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new TwitterFollowButtonWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageValue").Should().BeNull();
      widget.GetPropertyValue<string>("SizeValue").Should().BeNull();
      widget.GetPropertyValue<string>("AlignmentValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("CounterValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("ScreenNameValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("SuggestionsValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(account => Test(account, Widget));
    }

    return;

    static void Test(string account, ITwitterFollowButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new[] { Fixture<string>.Create() }.ForEach(language => Test(language, Widget));
    }

    return;

    static void Test(string language, ITwitterFollowButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new[] { Fixture<string>.Create() }.ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(string size, ITwitterFollowButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Alignment(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Alignment(null)).ThrowExactly<ArgumentNullException>().WithParameterName("alignment");
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Alignment(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("alignment");

      new[] { Fixture<string>.Create() }.ForEach(alignment => Test(alignment, Widget));
    }

    return;

    static void Test(string alignment, ITwitterFollowButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentValue").Should().Be(alignment);
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, ITwitterFollowButtonWidget widget) => widget.Counter(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("CounterValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ScreenName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ScreenName_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, ITwitterFollowButtonWidget widget) => widget.ScreenName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("ScreenNameValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, ITwitterFollowButtonWidget widget) => widget.Suggestions(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("SuggestionsValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new TwitterFollowButtonWidget());
      Test(Fixture<TwitterFollowButtonWidget>.Create());
    }

    return;

    static void Test(ITwitterFollowButtonWidget original)
    {
      var clone = original.Clone<ITwitterFollowButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<string>("AlignmentValue").Should().Be(original.GetPropertyValue<string>("AlignmentValue"));
      clone.GetPropertyValue<bool?>("CounterValue").Should().Be(original.GetPropertyValue<bool?>("CounterValue"));
      clone.GetPropertyValue<bool?>("ScreenNameValue").Should().Be(original.GetPropertyValue<bool?>("ScreenNameValue"));
      clone.GetPropertyValue<bool?>("SuggestionsValue").Should().Be(original.GetPropertyValue<bool?>("SuggestionsValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new TwitterFollowButtonWidget().Account("account"), $"""<a class="twitter-follow-button" data-lang="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" href="https://twitter.com/account"></a>""");
      Test(new TwitterFollowButtonWidget().Account("account").Language("en").Counter(true).Size("size").Width("width").Alignment("align").ScreenName(true).Suggestions(false), """<a class="twitter-follow-button" data-align="align" data-dnt="true" data-lang="en" data-show-count="true" data-show-screen-name="true" data-size="size" data-width="width" href="https://twitter.com/account"></a>""");
      Test(Fixture<TwitterFollowButtonWidget>.Create());
    }

    return;

    static void Test(ITwitterFollowButtonWidget widget, params string[] html)
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