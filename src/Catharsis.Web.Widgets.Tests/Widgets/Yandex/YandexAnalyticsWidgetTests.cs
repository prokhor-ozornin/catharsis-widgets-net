using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexAnalyticsWidget"/>.</para>
/// </summary>
public sealed class YandexAnalyticsWidgetTests : ClassTest<YandexAnalyticsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexAnalyticsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexAnalyticsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexAnalyticsWidget>();

    var widget = new YandexAnalyticsWidget();
    widget.Account().Should().BeNull();
    widget.WebVisor().Should().BeTrue();
    widget.ClickMap().Should().BeTrue();
    widget.TrackLinks().Should().BeTrue();
    widget.TrackHash().Should().BeTrue();
    widget.Accurate().Should().BeTrue();
    widget.NoIndex().Should().BeFalse();
    widget.Language().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IYandexAnalyticsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.WebVisor(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void WebVisor_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.WebVisor(enabled).Should().BeSameAs(widget);
      widget.WebVisor().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.ClickMap(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ClickMap_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.ClickMap(enabled).Should().BeSameAs(widget);
      widget.ClickMap().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackLinks(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLinks_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.TrackLinks(enabled).Should().BeSameAs(widget);
      widget.TrackLinks().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackHash(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackHash_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.TrackHash(enabled).Should().BeSameAs(widget);
      widget.TrackHash().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Accurate(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Accurate_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.Accurate(enabled).Should().BeSameAs(widget);
      widget.Accurate().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.NoIndex(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void NoIndex_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexAnalyticsWidget widget)
    {
      widget.NoIndex(enabled).Should().BeSameAs(widget);
      widget.NoIndex().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Language(null));
    Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Language(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, IYandexAnalyticsWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new YandexAnalyticsWidget().ToString());
      
    var html = new YandexAnalyticsWidget().Account("account").ToString();
    Assert.True(html.Contains($"Ya.Metrika.informer({{i: this, id: account, lang: '${Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}'}})"));
    Assert.True(html.Contains("yaCounteraccount"));
    Assert.True(html.Contains("""
                              "webvisor":true
                              """));
    Assert.True(html.Contains("""
                              "clickmap":true
                              """));
    Assert.True(html.Contains("""
                              "trackLinks":true
                              """));
    Assert.True(html.Contains("""
                              "accurateTrackBounce":true
                              """));
    Assert.True(html.Contains("""
                              "trackHash":true
                              """));
    Assert.False(html.Contains("""
                               "ut":"noindex"
                               """));

    html = new YandexAnalyticsWidget().Account("account").Language("language").WebVisor(false).ClickMap(false).TrackLinks(false).Accurate(false).TrackHash(false).NoIndex(true).ToString();
    Assert.True(html.Contains("Ya.Metrika.informer({i: this, id: account, lang: 'language'})"));
    Assert.True(html.Contains("yaCounteraccount"));
    Assert.True(html.Contains("""
                              "webvisor":false
                              """));
    Assert.True(html.Contains("""
                              "clickmap":false
                              """));
    Assert.True(html.Contains("""
                              "trackLinks":false
                              """));
    Assert.True(html.Contains("""
                              "accurateTrackBounce":false
                              """));
    Assert.True(html.Contains("""
                              "trackHash":false
                              """));
    Assert.True(html.Contains("""
                              "ut":"noindex"
                              """));

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