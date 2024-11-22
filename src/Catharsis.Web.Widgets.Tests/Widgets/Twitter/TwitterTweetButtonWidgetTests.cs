using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterTweetButtonWidget"/>.</para>
/// </summary>
public sealed class TwitterTweetButtonWidgetTests : ClassTest<TwitterTweetButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterTweetButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TwitterTweetButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITwitterTweetButtonWidget>();

    var widget = new TwitterTweetButtonWidget();
    widget.Url().Should().BeNull();
    widget.Language().Should().BeNull();
    widget.Text().Should().BeNull();
    widget.Via().Should().BeNull();
    widget.Size().Should().BeNull();
    widget.CountUrl().Should().BeNull();
    widget.CounterPosition().Should().BeNull();
    widget.Suggestions().Should().BeNull();
    widget.HashTags().Should().BeEmpty();
    widget.RelatedAccounts().Should().BeEmpty();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, ITwitterTweetButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Language(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Language(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, ITwitterTweetButtonWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Text(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Text(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string text, ITwitterTweetButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Via(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Via_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Via(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Via(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string via, ITwitterTweetButtonWidget widget)
    {
      widget.Via(via).Should().BeSameAs(widget);
      widget.Via().Should().Be(via);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Size(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Size(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, ITwitterTweetButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CountUrl(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CountUrl_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().CountUrl(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().CountUrl(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, ITwitterTweetButtonWidget widget)
    {
      widget.CountUrl(url).Should().BeSameAs(widget);
      widget.CountUrl().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CounterPosition(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CounterPosition_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().CounterPosition(null));
    Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().CounterPosition(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string position, ITwitterTweetButtonWidget widget)
    {
      widget.CounterPosition(position).Should().BeSameAs(widget);
      widget.CounterPosition().Should().Be(position);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, ITwitterTweetButtonWidget widget)
    {
      widget.Suggestions(enabled).Should().BeSameAs(widget);
      widget.Suggestions().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.HashTags(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void HashTags_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().HashTags(null));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { Enumerable.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<string> tags, ITwitterTweetButtonWidget widget)
    {
      widget.HashTags(tags).Should().BeSameAs(widget);
      widget.HashTags().Should().Equal(tags);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void RelatedAccounts_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().RelatedAccounts(null));

    using (new AssertionScope())
    {
      var widget = new TwitterTweetButtonWidget();
      new[] { Enumerable.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<string> tags, ITwitterTweetButtonWidget widget)
    {
      widget.RelatedAccounts(tags).Should().BeSameAs(widget);
      widget.RelatedAccounts().Should().Equal(tags);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal($"""<a class="twitter-share-button" data-lang="{(HttpContext.Current is not null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)}" href="https://twitter.com/share"></a>""", new TwitterTweetButtonWidget().ToString());
    Assert.Equal("""<a class="twitter-hashtag-button" data-count="counterPosition" data-counturl="countUrl" data-dnt="true" data-hashtags="tags" data-lang="en" data-related="related" data-size="size" data-text="text" data-url="url" data-via="via" href="https://twitter.com/share"></a>""", new TwitterTweetButtonWidget().Language("en").Url("url").Via("via").Text("text").RelatedAccounts("related").CounterPosition("counterPosition").CountUrl("countUrl").HashTags("tags").Size("size").Suggestions(false).ToString());
  }
}