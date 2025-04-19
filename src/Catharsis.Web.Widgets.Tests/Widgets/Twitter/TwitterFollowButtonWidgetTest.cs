using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterFollowButtonWidget"/>.</para>
/// </summary>
public sealed class TwitterFollowButtonWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageProperty").Should().BeNull();
      widget.GetPropertyValue<string>("SizeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("AlignmentProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("CounterProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("ScreenNameProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("SuggestionsProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
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

      new TwitterFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, ITwitterFollowButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
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

      new TwitterFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string language, ITwitterFollowButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(language);
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

      new TwitterFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string size, ITwitterFollowButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size);
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

      new TwitterFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string alignment, ITwitterFollowButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentProperty").Should().Be(alignment);
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      new TwitterFollowButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget) => widget.Counter(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("CounterProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ScreenName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ScreenName_Method()
  {
    using (new AssertionScope())
    {
      new TwitterFollowButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget) => widget.ScreenName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("ScreenNameProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      new TwitterFollowButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget) => widget.Suggestions(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("SuggestionsProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new TwitterFollowButtonWidget().Account("account"), $"""<a class="twitter-follow-button" data-lang="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" href="https://twitter.com/account"></a>""");
      Validate(new TwitterFollowButtonWidget().Account("account").Language("en").Counter(true).Size("size").Width("width").Alignment("align").ScreenName(true).Suggestions(false), """<a class="twitter-follow-button" data-align="align" data-dnt="true" data-lang="en" data-show-count="true" data-show-screen-name="true" data-size="size" data-width="width" href="https://twitter.com/account"></a>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
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