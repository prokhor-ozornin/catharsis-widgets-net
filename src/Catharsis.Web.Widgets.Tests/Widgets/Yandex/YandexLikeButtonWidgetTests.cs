using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexLikeButtonWidget"/>.</para>
/// </summary>
public sealed class YandexLikeButtonWidgetTests : ClassTest<YandexLikeButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexLikeButtonWidget>();

    var widget = new YandexLikeButtonWidget();
    widget.Url().Should().BeNull();
    widget.Title().Should().BeNull();
    widget.Size().Should().Be(YandexLikeButtonSize.Large.ToString().ToLowerInvariant());
    widget.Layout().Should().Be(YandexLikeButtonLayout.Button.ToString().ToLowerInvariant());
    widget.Text().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

      var widget = new YandexLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IYandexLikeButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Title(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Title(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("title");

      var widget = new YandexLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string title, IYandexLikeButtonWidget widget)
    {
      widget.Title(title).Should().BeSameAs(widget);
      widget.Title().Should().Be(title);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("size");

      var widget = new YandexLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, IYandexLikeButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("layout");

      var widget = new YandexLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string layout, IYandexLikeButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("text");
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Text(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("text");

      var widget = new YandexLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string text, IYandexLikeButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexLikeButtonWidget(), """<a name="ya-share" size="large" type="button"></a>""");
      Validate(new YandexLikeButtonWidget().Layout("icon").Size("small").Text("text").Url("url").Title("title"), """<a name="ya-share" share_text="text" share_title="title" share_url="url" size="small" type="icon"></a>""");
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