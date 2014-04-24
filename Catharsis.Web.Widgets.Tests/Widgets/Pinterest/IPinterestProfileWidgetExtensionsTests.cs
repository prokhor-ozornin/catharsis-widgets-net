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

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Field("height").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Width(IPinterestProfileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Width(null, 0));

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Header(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Header(null));

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Header(), widget));
        Assert.Equal("115", widget.Field("image").To<string>());
        Assert.Equal("120", widget.Field("height").To<string>());
        Assert.Equal("900", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Image(IPinterestProfileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Image(null, 0));

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Image(1), widget));
        Assert.Equal("1", widget.Field("image").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Sidebar(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sidebar_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Sidebar(null));

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sidebar(), widget));
        Assert.Equal("60", widget.Field("image").To<string>());
        Assert.Equal("800", widget.Field("height").To<string>());
        Assert.Equal("150", widget.Field("width").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Square(IPinterestProfileWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Square_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestProfileWidgetExtensions.Square(null));

      new PinterestProfileWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Square(), widget));
        Assert.Equal("80", widget.Field("image").To<string>());
        Assert.Equal("320", widget.Field("height").To<string>());
        Assert.Equal("400", widget.Field("width").To<string>());
      });
    }
  }
}