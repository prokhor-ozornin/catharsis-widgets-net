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
    Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Title(null));
    Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Title(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Size(null));
    Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Size(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Layout(null));
    Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Layout(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Text(null));
    Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Text(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.True(new YandexLikeButtonWidget().ToString().Contains("""<a name="ya-share" size="large" type="button"></a>"""));
    Assert.True(new YandexLikeButtonWidget().Layout("icon").Size("small").Text("text").Url("url").Title("title").ToString().Contains("""<a name="ya-share" share_text="text" share_title="title" share_url="url" size="small" type="icon"></a>"""));
  }
}