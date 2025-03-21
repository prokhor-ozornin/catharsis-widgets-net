using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexAnalyticsWidget"/>.</para>
/// </summary>
public sealed class YandexAnalyticsWidgetTests : UnitTest
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("language");

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
    using (new AssertionScope())
    {
      Validate(new YandexAnalyticsWidget());
      
      Validate(new YandexAnalyticsWidget().Account("account"),
               $"Ya.Metrika.informer({{i: this, id: account, lang: '${Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}'}})",
               "yaCounteraccount",
               """
               "webvisor":true
               """,
               """
               "clickmap":true
               """,
               """
               "trackLinks":true
               """,
               """
               "accurateTrackBounce":true
               """,
               """
               "trackHash":true
               """,
               """
               "ut":"noindex"
               """
               );

      Validate(new YandexAnalyticsWidget().Account("account").Language("language").WebVisor(false).ClickMap(false).TrackLinks(false).Accurate(false).TrackHash(false).NoIndex(true),
               "Ya.Metrika.informer({i: this, id: account, lang: 'language'})",
               "yaCounteraccount",
               """
               "webvisor":false
               """,
               """
               "clickmap":false
               """,
               """
               "trackLinks":false
               """,
               """
               "accurateTrackBounce":false
               """,
               """
               "trackHash":false
               """,
               """
               "ut":"noindex"
               """
        );
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