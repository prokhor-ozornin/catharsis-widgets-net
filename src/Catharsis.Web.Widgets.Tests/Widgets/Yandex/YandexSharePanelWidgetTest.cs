using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexSharePanelWidget"/>.</para>
/// </summary>
/// <seealso cref="YandexSharePanelWidget"/>
public sealed class YandexSharePanelWidgetTest : Test
{
  private IYandexSharePanelWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexSharePanelWidgetTest() => Widget = Fixture<IYandexSharePanelWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexSharePanelWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexSharePanelWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexSharePanelWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexSharePanelWidget();
      widget.GetPropertyValue<string>("LanguageValue").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutValue").Should().Be(nameof(YandexSharePanelLayout.Button).ToLowerInvariant());
      widget.GetPropertyValue<IEnumerable<string>>("ServicesValue").Should().Equal("yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexSharePanelWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new YandexSharePanelWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new[] { Fixture<string>.Create() }.ForEach(language => Test(language, Widget));
    }

    return;

    static void Test(string language, IYandexSharePanelWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Services(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Services_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexSharePanelWidget().Services(null)).ThrowExactly<ArgumentNullException>().WithParameterName("services");

      new[] { Enumerable.Empty<string>(), [Fixture<string>.Create()] }.ForEach(services => Test(services, Widget));
    }

    return;

    static void Test(IEnumerable<string> services, IYandexSharePanelWidget widget) => widget.Services(services).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ServicesValue").Should().Equal(services);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexSharePanelWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new YandexSharePanelWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new[] { Fixture<string>.Create() }.ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(string layout, IYandexSharePanelWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexSharePanelWidget());
      Test(Fixture<YandexSharePanelWidget>.Create());
    }

    return;

    static void Test(IYandexSharePanelWidget original)
    {
      var clone = original.Clone<IYandexSharePanelWidget>();

      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
      clone.GetPropertyValue<string>("LayoutValue").Should().Be(original.GetPropertyValue<string>("LayoutValue"));
      clone.GetPropertyValue<IEnumerable<string>>("ServicesValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("ServicesValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexSharePanelWidget(), $"""<div class="yashare-auto-init" data-yashareL10n="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" data-yashareQuickServices="yaru,vkontakte,facebook,twitter,odnoklassniki,moimir,lj,friendfeed,moikrug,gplus,pinterest,surfingbird" data-yashareType="button"></div>""");
      Test(new YandexSharePanelWidget().Services("yaru").Layout(YandexSharePanelLayout.Link).Language("ru"), """<div class="yashare-auto-init" data-yashareL10n="ru" data-yashareQuickServices="yaru" data-yashareType="link"></div>""");
      Test(Fixture<YandexSharePanelWidget>.Create());
    }

    return;

    static void Test(IYandexSharePanelWidget widget, params string[] html)
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