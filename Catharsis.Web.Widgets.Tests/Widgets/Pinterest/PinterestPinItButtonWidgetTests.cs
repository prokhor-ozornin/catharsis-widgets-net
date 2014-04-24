using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestPinItButtonWidget"/>.</para>
  /// </summary>
  public sealed class PinterestPinItButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="PinterestPinItButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new PinterestPinItButtonWidget();
      Assert.Equal("gray", widget.Field("color").To<string>());
      Assert.Equal(PinterestPinItButtonPinCountPosition.None, widget.Field("counter").To<PinterestPinItButtonPinCountPosition>());
      Assert.Null(widget.Field("description"));
      Assert.Null(widget.Field("image"));
      Assert.Equal("en", widget.Field("language").To<string>());
      Assert.Equal(PinterestPinItButtonShape.Rectangular, widget.Field("shape").To<PinterestPinItButtonShape>());
      Assert.Equal(PinterestPinItButtonSize.Small, widget.Field("size").To<PinterestPinItButtonSize>());
      Assert.Null(widget.Field("url"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Color(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Color(string.Empty));

      var widget = new PinterestPinItButtonWidget();
      Assert.Equal("gray", widget.Field("color").To<string>());
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.Equal("color", widget.Field("color").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Counter(PinterestPinItButtonPinCountPosition)"/> method.</para>
    /// </summary>
    [Fact]
    public void Counter_Method()
    {
      var widget = new PinterestPinItButtonWidget();
      Assert.Equal(PinterestPinItButtonPinCountPosition.None, widget.Field("counter").To<PinterestPinItButtonPinCountPosition>());
      Assert.True(ReferenceEquals(widget.Counter(PinterestPinItButtonPinCountPosition.Above), widget));
      Assert.Equal(PinterestPinItButtonPinCountPosition.Above, widget.Field("counter").To<PinterestPinItButtonPinCountPosition>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Description(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Description_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Color(string.Empty));

      var widget = new PinterestPinItButtonWidget();
      Assert.Null(widget.Field("description"));
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Field("description").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Image(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Image(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Image(string.Empty));

      var widget = new PinterestPinItButtonWidget();
      Assert.Null(widget.Field("image"));
      Assert.True(ReferenceEquals(widget.Image("image"), widget));
      Assert.Equal("image", widget.Field("image").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Language(string.Empty));

      var widget = new PinterestPinItButtonWidget();
      Assert.Equal("en", widget.Field("language").To<string>());
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Field("language").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Shape(PinterestPinItButtonShape)"/> method.</para>
    /// </summary>
    [Fact]
    public void Shape_Method()
    {
      var widget = new PinterestPinItButtonWidget();
      Assert.Equal(PinterestPinItButtonShape.Rectangular, widget.Field("shape").To<PinterestPinItButtonShape>());
      Assert.True(ReferenceEquals(widget.Shape(PinterestPinItButtonShape.Circular), widget));
      Assert.Equal(PinterestPinItButtonShape.Circular, widget.Field("shape").To<PinterestPinItButtonShape>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Size(PinterestPinItButtonSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      var widget = new PinterestPinItButtonWidget();
      Assert.Equal(PinterestPinItButtonSize.Small, widget.Field("size").To<PinterestPinItButtonSize>());
      Assert.True(ReferenceEquals(widget.Size(PinterestPinItButtonSize.Large), widget));
      Assert.Equal(PinterestPinItButtonSize.Large, widget.Field("size").To<PinterestPinItButtonSize>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinItButtonWidget().Url(string.Empty));

      var widget = new PinterestPinItButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinItButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new PinterestPinItButtonWidget().ToString());
      Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Url("url").Image("image").ToString());
      Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Url("url").Description("description").ToString());
      Assert.Equal(string.Empty, new PinterestPinItButtonWidget().Image("image").Description("description").ToString());
      Assert.Equal(@"<a data-pin-color=""gray"" data-pin-config=""none"" data-pin-do=""buttonPin"" data-pin-height=""20"" data-pin-lang=""en"" data-pin-shape=""rect"" href=""http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description""><img src=""http://assets.pinterest.com/images/pidgets/pinit_fg_en_rect_gray_20.png""/></a>", new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").ToString());
      Assert.Equal(@"<a data-pin-color=""color"" data-pin-config=""above"" data-pin-do=""buttonPin"" data-pin-height=""28"" data-pin-lang=""language"" data-pin-shape=""rect"" href=""http://www.pinterest.com/pin/create/button/?url=url&amp;media=image&amp;description=description""><img src=""http://assets.pinterest.com/images/pidgets/pinit_fg_language_rect_color_28.png""/></a>", new PinterestPinItButtonWidget().Url("url").Image("image").Description("description").Color("color").Counter(PinterestPinItButtonPinCountPosition.Above).Language("language").Size(PinterestPinItButtonSize.Large).ToString());
    }
  }
}