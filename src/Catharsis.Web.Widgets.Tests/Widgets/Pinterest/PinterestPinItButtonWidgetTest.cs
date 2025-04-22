using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestPinItButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestPinItButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestPinItButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestPinItButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestPinItButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      widget.GetPropertyValue<string>("ColorProperty").Should().Be("gray");
      widget.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterProperty").Should().Be(PinterestPinItButtonPinCountPosition.None);
      widget.GetPropertyValue<string>("DescriptionProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ImageProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageProperty").Should().Be("en");
      widget.GetPropertyValue<PinterestPinItButtonShape>("ShapeProperty").Should().Be(PinterestPinItButtonShape.Rectangular);
      widget.GetPropertyValue<PinterestPinItButtonSize>("SizeProperty").Should().Be(PinterestPinItButtonSize.Small);
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Color(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Color(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new PinterestPinItButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IPinterestPinItButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Counter(PinterestPinItButtonPinCountPosition)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      new PinterestPinItButtonWidget().With(widget => Enum.GetValues<PinterestPinItButtonPinCountPosition>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(PinterestPinItButtonPinCountPosition position, IPinterestPinItButtonWidget widget) => widget.Counter(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterProperty").Should().Be(position);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Description(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Description(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("description");

      new PinterestPinItButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string description, IPinterestPinItButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionProperty").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Image(null)).ThrowExactly<ArgumentNullException>().WithParameterName("image");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("image");

      new PinterestPinItButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string image, IPinterestPinItButtonWidget widget) => widget.Image(image).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageProperty").Should().Be(image);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new PinterestPinItButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string language, IPinterestPinItButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Shape(PinterestPinItButtonShape)"/> method.</para>
  /// </summary>
  [Fact]
  public void Shape_Method()
  {
    using (new AssertionScope())
    {
      new PinterestPinItButtonWidget().With(widget => Enum.GetValues<PinterestPinItButtonShape>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(PinterestPinItButtonShape shape, IPinterestPinItButtonWidget widget) => widget.Shape(shape).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonShape>("ShapeProperty").Should().Be(shape);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Size(PinterestPinItButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      new PinterestPinItButtonWidget().With(widget => Enum.GetValues<PinterestPinItButtonSize>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(PinterestPinItButtonSize size, IPinterestPinItButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonSize>("SizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new PinterestPinItButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IPinterestPinItButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestPinItButtonWidget());
      Validate(new PinterestPinItButtonWidget().Url("url").Image("image"));
      Validate(new PinterestPinItButtonWidget().Url("url").Description("description"));
      Validate(new PinterestPinItButtonWidget().Image("image").Description("description"));
      Validate(new PinterestPinItButtonWidget().Url("url").Image("image").Description("description"), """<a data-pin-color="gray" data-pin-config="none" data-pin-do="buttonPin" data-pin-height="20" data-pin-lang="en" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_en_rect_gray_20.png"/></a>""");
      Validate(new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").Color("color").Counter(PinterestPinItButtonPinCountPosition.Above).Language("language").Size(PinterestPinItButtonSize.Large), """<a data-pin-color="color" data-pin-config="above" data-pin-do="buttonPin" data-pin-height="28" data-pin-lang="language" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_language_rect_color_28.png"/></a>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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