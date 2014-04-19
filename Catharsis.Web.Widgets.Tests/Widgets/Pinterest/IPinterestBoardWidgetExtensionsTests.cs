using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IPinterestBoardWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IPinterestBoardWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Height(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Height(null, 0));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Field("height").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Width(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Width(null, 0));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Header(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Header(null));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Header(), widget));
        Assert.Equal("115", widget.Field("imageWidth").To<string>());
        Assert.Equal("120", widget.Field("height").To<string>());
        Assert.Equal("900", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.ImageWidth(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void ImageWidth_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.ImageWidth(null, 0));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.ImageWidth(1), widget));
        Assert.Equal("1", widget.Field("imageWidth").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Sidebar(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sidebar_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Sidebar(null));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sidebar(), widget));
        Assert.Equal("60", widget.Field("imageWidth").To<string>());
        Assert.Equal("800", widget.Field("height").To<string>());
        Assert.Equal("150", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Square(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Square_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Square(null));

      new PinterestBoardWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Square(), widget));
        Assert.Equal("80", widget.Field("imageWidth").To<string>());
        Assert.Equal("320", widget.Field("height").To<string>());
        Assert.Equal("400", widget.Field("width").To<string>());
      });
    }
  }
}