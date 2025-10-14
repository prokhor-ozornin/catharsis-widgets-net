using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexAnalyticsWidget"/>.</para>
/// </summary>
/// <seealso cref="YandexAnalyticsWidget"/>
public sealed class YandexAnalyticsWidgetTest : Test
{
  private IYandexAnalyticsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexAnalyticsWidgetTest() => Widget = Fixture<IYandexAnalyticsWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexAnalyticsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexAnalyticsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexAnalyticsWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexAnalyticsWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<bool>("WebVisorValue").Should().BeTrue();
      widget.GetPropertyValue<bool>("ClickMapValue").Should().BeTrue();
      widget.GetPropertyValue<bool>("TrackLinksValue").Should().BeTrue();
      widget.GetPropertyValue<bool>("TrackHashValue").Should().BeTrue();
      widget.GetPropertyValue<bool>("AccurateValue").Should().BeTrue();
      widget.GetPropertyValue<bool>("NoIndexValue").Should().BeFalse();
      widget.GetPropertyValue<string>("LanguageValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(account => Test(account, Widget));
    }

    return;

    static void Test(string account, IYandexAnalyticsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.WebVisor(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void WebVisor_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.WebVisor(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("WebVisorValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.ClickMap(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ClickMap_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.ClickMap(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("ClickMapValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackLinks(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLinks_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.TrackLinks(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("TrackLinksValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackHash(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackHash_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.TrackHash(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("TrackHashValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Accurate(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Accurate_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.Accurate(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AccurateValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.NoIndex(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void NoIndex_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYandexAnalyticsWidget widget) => widget.NoIndex(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("NoIndexValue").Should().Be(enabled);
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
      AssertionExtensions.Should(() => new YandexAnalyticsWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new[] { Fixture<string>.Create() }.ForEach(language => Test(language, Widget));
    }

    return;

    static void Test(string language, IYandexAnalyticsWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexAnalyticsWidget());
      Test(Fixture<YandexAnalyticsWidget>.Create());
    }

    return;

    static void Test(IYandexAnalyticsWidget original)
    {
      var clone = original.Clone<IYandexAnalyticsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<bool>("WebVisorValue").Should().Be(original.GetPropertyValue<bool>("WebVisorValue"));
      clone.GetPropertyValue<bool>("ClickMapValue").Should().Be(original.GetPropertyValue<bool>("ClickMapValue"));
      clone.GetPropertyValue<bool>("TrackLinksValue").Should().Be(original.GetPropertyValue<bool>("TrackLinksValue"));
      clone.GetPropertyValue<bool>("TrackHashValue").Should().Be(original.GetPropertyValue<bool>("TrackHashValue"));
      clone.GetPropertyValue<bool>("AccurateValue").Should().Be(original.GetPropertyValue<bool>("AccurateValue"));
      clone.GetPropertyValue<bool>("NoIndexValue").Should().Be(original.GetPropertyValue<bool>("NoIndexValue"));
      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
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
      Test(new YandexAnalyticsWidget());
      
      Test(new YandexAnalyticsWidget().Account("account"),
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

      Test(new YandexAnalyticsWidget().Account("account").Language("language").WebVisor(false).ClickMap(false).TrackLinks(false).Accurate(false).TrackHash(false).NoIndex(true),
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
      Test(Fixture<YandexAnalyticsWidget>.Create());
    }

    return;

    static void Test(IYandexAnalyticsWidget widget, params string[] html)
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