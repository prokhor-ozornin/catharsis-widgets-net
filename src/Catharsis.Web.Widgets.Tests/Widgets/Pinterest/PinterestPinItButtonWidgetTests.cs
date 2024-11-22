using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="PinterestPinItButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestPinItButtonWidgetTests : ClassTest<PinterestPinItButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestPinItButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestPinItButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestPinItButtonWidget>();

    var widget = new PinterestPinItButtonWidget();
    widget.Color().Should().Be("gray");
    widget.Counter().Should().Be(PinterestPinItButtonPinCountPosition.None);
    widget.Description().Should().BeNull();
    widget.Image().Should().BeNull();
    widget.Language().Should().Be("en");
    widget.Shape().Should().Be(PinterestPinItButtonShape.Rectangular);
    widget.Size().Should().Be(PinterestPinItButtonSize.Small);
    widget.Url().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Color(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Color(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IPinterestPinItButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.Color().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Counter(PinterestPinItButtonPinCountPosition)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      Enum.GetValues<PinterestPinItButtonPinCountPosition>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(PinterestPinItButtonPinCountPosition position, IPinterestPinItButtonWidget widget)
    {
      widget.Counter(position).Should().BeSameAs(widget);
      widget.Counter().Should().Be(position);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Color(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Color(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string description, IPinterestPinItButtonWidget widget)
    {
      widget.Description(description).Should().BeSameAs(widget);
      widget.Description().Should().Be(description);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Image(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Image(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string image, IPinterestPinItButtonWidget widget)
    {
      widget.Image(image).Should().BeSameAs(widget);
      widget.Image().Should().Be(image);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Language(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Language(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, IPinterestPinItButtonWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Shape(PinterestPinItButtonShape)"/> method.</para>
  /// </summary>
  [Fact]
  public void Shape_Method()
  {
    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      Enum.GetValues<PinterestPinItButtonShape>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(PinterestPinItButtonShape shape, IPinterestPinItButtonWidget widget)
    {
      widget.Shape(shape).Should().BeSameAs(widget);
      widget.Shape().Should().Be(shape);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Size(PinterestPinItButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      Enum.GetValues<PinterestPinItButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(PinterestPinItButtonSize size, IPinterestPinItButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinItButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IPinterestPinItButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new PinterestPinItButtonWidget().ToString());
    Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Url("url").Image("image").ToString());
    Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Url("url").Description("description").ToString());
    Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Image("image").Description("description").ToString());
    Assert.Equal("""<a data-pin-color="gray" data-pin-config="none" data-pin-do="buttonPin" data-pin-height="20" data-pin-lang="en" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_en_rect_gray_20.png"/></a>""", new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").ToString());
    Assert.Equal("""<a data-pin-color="color" data-pin-config="above" data-pin-do="buttonPin" data-pin-height="28" data-pin-lang="language" data-pin-shape="rect" href="http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description"><img src="http://assets.pinterest.com/images/pidgets/pinit_fg_language_rect_color_28.png"/></a>""", new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").Color("color").Counter(PinterestPinItButtonPinCountPosition.Above).Language("language").Size(PinterestPinItButtonSize.Large).ToString());
  }
}