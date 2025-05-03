using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterTweetButtonWidget"/>.</para>
/// </summary>
public sealed class TwitterTweetButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterTweetButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TwitterTweetButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITwitterTweetButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TextProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ViaProperty").Should().BeNull();
      widget.GetPropertyValue<string>("SizeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("CountUrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("CounterPositionProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("SuggestionsProperty").Should().BeNull();
      widget.GetPropertyValue<IEnumerable<string>>("TagsProperty").Should().BeEmpty();
      widget.GetPropertyValue<IEnumerable<string>>("AccountsProperty").Should().BeEmpty();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, ITwitterTweetButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string language, ITwitterTweetButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("text");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Text(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("text");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string text, ITwitterTweetButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Via(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Via_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Via(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Via(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string via, ITwitterTweetButtonWidget widget) => widget.Via(via).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ViaProperty").Should().Be(via);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string size, ITwitterTweetButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CountUrl(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CountUrl_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().CountUrl(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().CountUrl(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, ITwitterTweetButtonWidget widget) => widget.CountUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CountUrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CounterPosition(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CounterPosition_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().CounterPosition(null)).ThrowExactly<ArgumentNullException>().WithParameterName("position");
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().CounterPosition(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("position");

      new TwitterTweetButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string position, ITwitterTweetButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionProperty").Should().Be(position);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      new TwitterTweetButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, ITwitterTweetButtonWidget widget) => widget.Suggestions(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("SuggestionsProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.HashTags(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void HashTags_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().HashTags(null)).ThrowExactly<ArgumentNullException>().WithParameterName("tags");

      new TwitterTweetButtonWidget().With(widget => new[] { Enumerable.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> tags, ITwitterTweetButtonWidget widget) => widget.HashTags(tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("TagsProperty").Should().Equal(tags);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void RelatedAccounts_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TwitterTweetButtonWidget().RelatedAccounts(null)).ThrowExactly<ArgumentNullException>().WithParameterName("accounts");

      new TwitterTweetButtonWidget().With(widget => new[] { Enumerable.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> tags, ITwitterTweetButtonWidget widget) => widget.RelatedAccounts(tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AccountsProperty").Should().Equal(tags);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new TwitterTweetButtonWidget());
      Validate(Attributes.TwitterTweetButtonWidget());
    }

    return;

    static void Validate(ITwitterTweetButtonWidget original)
    {
      var clone = original.Clone<ITwitterTweetButtonWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new TwitterTweetButtonWidget(), $"""<a class="twitter-share-button" data-lang="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" href="https://twitter.com/share"></a>""");
      Validate(new TwitterTweetButtonWidget().Language("en").Url("url").Via("via").Text("text").RelatedAccounts("related").CounterPosition("counterPosition").CountUrl("countUrl").HashTags("tags").Size("size").Suggestions(false), """<a class="twitter-hashtag-button" data-count="counterPosition" data-counturl="countUrl" data-dnt="true" data-hashtags="tags" data-lang="en" data-related="related" data-size="size" data-text="text" data-url="url" data-via="via" href="https://twitter.com/share"></a>""");
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