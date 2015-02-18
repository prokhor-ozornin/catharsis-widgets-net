using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IPinterestProfileWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IPinterestProfileWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Height(IPinterestProfileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Height(null, 0));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Height());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Width(IPinterestProfileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Width(null, 0));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Header(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Header(null));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Header(), widget));
        Assert.Equal("115", widget.Image());
        Assert.Equal("120", widget.Height());
        Assert.Equal("900", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Image(IPinterestProfileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Image(null, 0));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Image(1), widget));
        Assert.Equal("1", widget.Image());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Sidebar(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sidebar_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Sidebar(null));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sidebar(), widget));
        Assert.Equal("60", widget.Image());
        Assert.Equal("800", widget.Height());
        Assert.Equal("150", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Square(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Square_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Square(null));

      new PinterestProfileWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Square(), widget));
        Assert.Equal("80", widget.Image());
        Assert.Equal("320", widget.Height());
        Assert.Equal("400", widget.Width());
      });
    }
  }
}