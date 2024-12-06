using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexSharePanelWidget"/>.</para>
/// </summary>
public sealed class YandexSharePanelWidgetTests : ClassTest<YandexSharePanelWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexSharePanelWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexSharePanelWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexSharePanelWidget>();

    var widget = new YandexSharePanelWidget();
    widget.Language().Should().BeNull();
    widget.Layout().Should().Be(YandexSharePanelLayout.Button.ToString().ToLowerInvariant());
    widget.Services().Should().Equal(["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"]);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Language(null));
    Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Language(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexSharePanelWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, IYandexSharePanelWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Services(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Services_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Services(null));

    using (new AssertionScope())
    {
      var widget = new YandexSharePanelWidget();
      new[] { Enumerable.Empty<string>(), ["service"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<string> services, IYandexSharePanelWidget widget)
    {
      widget.Services(services).Should().BeSameAs(widget);
      widget.Services().Should().Equal(services);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Layout(null));
    Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Layout(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexSharePanelWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string layout, IYandexSharePanelWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
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
      Validate(new YandexSharePanelWidget(), $"""<div class="yashare-auto-init" data-yashareL10n="{Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName}" data-yashareQuickServices="yaru,vkontakte,facebook,twitter,odnoklassniki,moimir,lj,friendfeed,moikrug,gplus,pinterest,surfingbird" data-yashareType="button"></div>""");
      Validate(new YandexSharePanelWidget().Services("yaru").Layout(YandexSharePanelLayout.Link).Language("ru"), """<div class="yashare-auto-init" data-yashareL10n="ru" data-yashareQuickServices="yaru" data-yashareType="link"></div>""");
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