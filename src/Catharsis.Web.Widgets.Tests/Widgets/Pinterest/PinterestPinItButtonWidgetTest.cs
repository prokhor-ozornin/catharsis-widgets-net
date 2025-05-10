using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestPinItButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestPinItButtonWidgetTest : Test
{
  private IPinterestPinItButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PinterestPinItButtonWidgetTest() => Widget = Fixture.Create<IPinterestPinItButtonWidget>();

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
      widget.GetPropertyValue<string>("ColorValue").Should().Be("gray");
      widget.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterValue").Should().Be(PinterestPinItButtonPinCountPosition.None);
      widget.GetPropertyValue<string>("DescriptionValue").Should().BeNull();
      widget.GetPropertyValue<string>("ImageValue").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageValue").Should().Be("en");
      widget.GetPropertyValue<PinterestPinItButtonShape>("ShapeValue").Should().Be(PinterestPinItButtonShape.Rectangular);
      widget.GetPropertyValue<PinterestPinItButtonSize>("SizeValue").Should().Be(PinterestPinItButtonSize.Small);
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IPinterestPinItButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Counter(PinterestPinItButtonPinCountPosition)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<PinterestPinItButtonPinCountPosition>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(PinterestPinItButtonPinCountPosition position, IPinterestPinItButtonWidget widget) => widget.Counter(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterValue").Should().Be(position);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string description, IPinterestPinItButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionValue").Should().Be(description);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string image, IPinterestPinItButtonWidget widget) => widget.Image(image).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(image);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string language, IPinterestPinItButtonWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Shape(PinterestPinItButtonShape)"/> method.</para>
  /// </summary>
  [Fact]
  public void Shape_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<PinterestPinItButtonShape>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(PinterestPinItButtonShape shape, IPinterestPinItButtonWidget widget) => widget.Shape(shape).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonShape>("ShapeValue").Should().Be(shape);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Size(PinterestPinItButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<PinterestPinItButtonSize>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(PinterestPinItButtonSize size, IPinterestPinItButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<PinterestPinItButtonSize>("SizeValue").Should().Be(size);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string url, IPinterestPinItButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PinterestPinItButtonWidget());
      Test(Fixture.Create<PinterestPinItButtonWidget>());
    }

    return;

    static void Test(IPinterestPinItButtonWidget original)
    {
      var clone = original.Clone<IPinterestPinItButtonWidget>();

      clone.GetPropertyValue<string>("ColorValue").Should().Be(original.GetPropertyValue<string>("ColorValue"));
      clone.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterValue").Should().Be(original.GetPropertyValue<PinterestPinItButtonPinCountPosition>("CounterValue"));
      clone.GetPropertyValue<string>("DescriptionValue").Should().Be(original.GetPropertyValue<string>("DescriptionValue"));
      clone.GetPropertyValue<string>("ImageValue").Should().Be(original.GetPropertyValue<string>("ImageValue"));
      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
      clone.GetPropertyValue<PinterestPinItButtonShape>("ShapeValue").Should().Be(original.GetPropertyValue<PinterestPinItButtonShape>("ShapeValue"));
      clone.GetPropertyValue<PinterestPinItButtonSize>("SizeValue").Should().Be(original.GetPropertyValue<PinterestPinItButtonSize>("SizeValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new PinterestPinItButtonWidget());
      Test(new PinterestPinItButtonWidget().Url("url").Image("image"));
      Test(new PinterestPinItButtonWidget().Url("url").Description("description"));
      Test(new PinterestPinItButtonWidget().Image("image").Description("description"));
      Test(new PinterestPinItButtonWidget().Url("url").Image("image").Description("description"), """<a data-pin-color="gray" data-pin-config="none" data-pin-do="buttonPin" data-pin-height="20" data-pin-lang="en" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_en_rect_gray_20.png"/></a>""");
      Test(new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").Color("color").Counter(PinterestPinItButtonPinCountPosition.Above).Language("language").Size(PinterestPinItButtonSize.Large), """<a data-pin-color="color" data-pin-config="above" data-pin-do="buttonPin" data-pin-height="28" data-pin-lang="language" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_language_rect_color_28.png"/></a>""");
      Test(Fixture.Create<PinterestPinItButtonWidget>());
    }

    return;

    static void Test(IPinterestPinItButtonWidget widget, params string[] html)
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