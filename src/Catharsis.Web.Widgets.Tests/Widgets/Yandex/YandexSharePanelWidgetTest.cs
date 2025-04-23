using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexSharePanelWidget"/>.</para>
/// </summary>
public sealed class YandexSharePanelWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("LanguageProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutProperty").Should().Be(YandexSharePanelLayout.Button.ToString().ToLowerInvariant());
      widget.GetPropertyValue<IEnumerable<string>>("ServicesProperty").Should().Equal(["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"]);
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

      new YandexSharePanelWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string language, IYandexSharePanelWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(language);
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

      new YandexSharePanelWidget().With(widget => new[] { Enumerable.Empty<string>(), ["service"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> services, IYandexSharePanelWidget widget) => widget.Services(services).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ServicesProperty").Should().Equal(services);
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

      new YandexSharePanelWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string layout, IYandexSharePanelWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutProperty").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexSharePanelWidget(), $"""<div class="yashare-auto-init" data-yashareL10n="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" data-yashareQuickServices="yaru,vkontakte,facebook,twitter,odnoklassniki,moimir,lj,friendfeed,moikrug,gplus,pinterest,surfingbird" data-yashareType="button"></div>""");
      Validate(new YandexSharePanelWidget().Services("yaru").Layout(YandexSharePanelLayout.Link).Language("ru"), """<div class="yashare-auto-init" data-yashareL10n="ru" data-yashareQuickServices="yaru" data-yashareType="link"></div>""");
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