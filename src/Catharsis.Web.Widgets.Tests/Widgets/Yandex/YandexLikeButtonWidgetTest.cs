using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexLikeButtonWidget"/>.</para>
/// </summary>
public sealed class YandexLikeButtonWidgetTest : Test
{
  private IYandexLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexLikeButtonWidgetTest() => Widget = Fixture.Create<IYandexLikeButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexLikeButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexLikeButtonWidget();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("TitleValue").Should().BeNull();
      widget.GetPropertyValue<string>("SizeValue").Should().Be(nameof(YandexLikeButtonSize.Large).ToLowerInvariant());
      widget.GetPropertyValue<string>("LayoutValue").Should().Be(nameof(YandexLikeButtonLayout.Button).ToLowerInvariant());
      widget.GetPropertyValue<string>("TextValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string url, IYandexLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Title(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string title, IYandexLikeButtonWidget widget) => widget.Title(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleValue").Should().Be(title);
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
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string size, IYandexLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
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
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string layout, IYandexLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout);
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
      AssertionExtensions.Should(() => new YandexLikeButtonWidget().Text(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("text");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string text, IYandexLikeButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextValue").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexLikeButtonWidget());
      Validate(Fixture.Create<IYandexLikeButtonWidget>());
    }

    return;

    static void Validate(IYandexLikeButtonWidget original)
    {
      var clone = original.Clone<IYandexLikeButtonWidget>();

      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("TitleValue").Should().Be(original.GetPropertyValue<string>("TitleValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<string>("LayoutValue").Should().Be(original.GetPropertyValue<string>("LayoutValue"));
      clone.GetPropertyValue<string>("TextValue").Should().Be(original.GetPropertyValue<string>("TextValue"));
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
      Validate(Fixture.Create<IYandexLikeButtonWidget>());
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