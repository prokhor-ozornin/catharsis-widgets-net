using System.Net.Http;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterFollowButtonWidget"/>.</para>
/// </summary>
public sealed class TwitterFollowButtonWidgetTests : ClassTest<TwitterFollowButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TwitterFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITwitterFollowButtonWidget>();

    var widget = new TwitterFollowButtonWidget();
    widget.Account().Should().BeNull();
    widget.Language().Should().BeNull();
    widget.Size().Should().BeNull();
    widget.Alignment().Should().BeNull();
    widget.Counter().Should().BeNull();
    widget.ScreenName().Should().BeNull();
    widget.Suggestions().Should().BeNull();
    widget.Width().Should().BeNull();
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
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

      var widget = new TwitterFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ITwitterFollowButtonWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
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
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("language");

      var widget = new TwitterFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, ITwitterFollowButtonWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
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
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("size");

      var widget = new TwitterFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, ITwitterFollowButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
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
      AssertionExtensions.Should(() => new TwitterFollowButtonWidget().Alignment(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("alignment");

      var widget = new TwitterFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string alignment, ITwitterFollowButtonWidget widget)
    {
      widget.Alignment(alignment).Should().BeSameAs(widget);
      widget.Alignment().Should().Be(alignment);
    }
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TwitterFollowButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget)
    {
      widget.Counter(enabled).Should().BeSameAs(widget);
      widget.Counter().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ScreenName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ScreenName_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TwitterFollowButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget)
    {
      widget.ScreenName(enabled).Should().BeSameAs(widget);
      widget.ScreenName().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Suggestions(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Suggestions_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TwitterFollowButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, ITwitterFollowButtonWidget widget)
    {
      widget.Suggestions(enabled).Should().BeSameAs(widget);
      widget.Suggestions().Should().Be(enabled);
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