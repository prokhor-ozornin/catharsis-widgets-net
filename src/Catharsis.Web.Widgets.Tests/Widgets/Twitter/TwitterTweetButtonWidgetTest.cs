using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterTweetButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="TwitterTweetButtonWidget"/>
public sealed class TwitterTweetButtonWidgetTest : Test
{
  private ITwitterTweetButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public TwitterTweetButtonWidgetTest() => Widget = Fixture<ITwitterTweetButtonWidget>.Create();

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
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageValue").Should().BeNull();
      widget.GetPropertyValue<string>("TextValue").Should().BeNull();
      widget.GetPropertyValue<string>("ViaValue").Should().BeNull();
      widget.GetPropertyValue<string>("SizeValue").Should().BeNull();
      widget.GetPropertyValue<string>("CountUrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("CounterPositionValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("SuggestionsValue").Should().BeNull();
      widget.GetPropertyValue<IEnumerable<string>>("TagsValue").Should().BeEmpty();
      widget.GetPropertyValue<IEnumerable<string>>("AccountsValue").Should().BeEmpty();
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, ITwitterTweetButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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

      new[] { Fixture<string>.Create() }.ForEach(language => Test(language, Widget));
    }

    return;

    static void Test(string language, ITwitterTweetButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
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

      new[] { Fixture<string>.Create() }.ForEach(text => Test(text, Widget));
    }

    return;

    static void Test(string text, ITwitterTweetButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextValue").Should().Be(text);
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

      new[] { Fixture<string>.Create() }.ForEach(via => Test(via, Widget));
    }

    return;

    static void Test(string via, ITwitterTweetButtonWidget widget) => widget.Via(via).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ViaValue").Should().Be(via);
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

      new[] { Fixture<string>.Create() }.ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(string size, ITwitterTweetButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, ITwitterTweetButtonWidget widget) => widget.CountUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CountUrlValue").Should().Be(url);
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

      new[] { Fixture<string>.Create() }.ForEach(position => Test(position, Widget));
    }

    return;

    static void Test(string position, ITwitterTweetButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionValue").Should().Be(position);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, ITwitterTweetButtonWidget widget) => widget.Suggestions(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("SuggestionsValue").Should().Be(enabled);
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

      new[] { Enumerable.Empty<string>(), [Fixture<string>.Create()] }.ForEach(tags => Test(tags, Widget));
    }

    return;

    static void Test(IEnumerable<string> tags, ITwitterTweetButtonWidget widget) => widget.HashTags(tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("TagsValue").Should().Equal(tags);
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

      new[] { Enumerable.Empty<string>(), [Fixture<string>.Create()] }.ForEach(tags => Test(tags, Widget));
    }

    return;

    static void Test(IEnumerable<string> tags, ITwitterTweetButtonWidget widget) => widget.RelatedAccounts(tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AccountsValue").Should().Equal(tags);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new TwitterTweetButtonWidget());
      Test(Fixture<TwitterTweetButtonWidget>.Create());
    }

    return;

    static void Test(ITwitterTweetButtonWidget original)
    {
      var clone = original.Clone<ITwitterTweetButtonWidget>();

      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
      clone.GetPropertyValue<string>("TextValue").Should().Be(original.GetPropertyValue<string>("TextValue"));
      clone.GetPropertyValue<string>("ViaValue").Should().Be(original.GetPropertyValue<string>("ViaValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<string>("CountUrlValue").Should().Be(original.GetPropertyValue<string>("CountUrlValue"));
      clone.GetPropertyValue<string>("CounterPositionValue").Should().Be(original.GetPropertyValue<string>("CounterPositionValue"));
      clone.GetPropertyValue<bool?>("SuggestionsValue").Should().Be(original.GetPropertyValue<bool?>("SuggestionsValue"));
      clone.GetPropertyValue<IEnumerable<string>>("AccountsValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("AccountsValue"));
      clone.GetPropertyValue<IEnumerable<string>>("TagsValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("TagsValue"));
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
      Test(new TwitterTweetButtonWidget(), $"""<a class="twitter-share-button" data-lang="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" href="https://twitter.com/share"></a>""");
      Test(new TwitterTweetButtonWidget().Language("en").Url("url").Via("via").Text("text").RelatedAccounts("related").CounterPosition("counterPosition").CountUrl("countUrl").HashTags("tags").Size("size").Suggestions(false), """<a class="twitter-hashtag-button" data-count="counterPosition" data-counturl="countUrl" data-dnt="true" data-hashtags="tags" data-lang="en" data-related="related" data-size="size" data-text="text" data-url="url" data-via="via" href="https://twitter.com/share"></a>""");
      Test(Fixture<TwitterTweetButtonWidget>.Create());
    }

    return;

    static void Test(ITwitterTweetButtonWidget widget, params string[] html)
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