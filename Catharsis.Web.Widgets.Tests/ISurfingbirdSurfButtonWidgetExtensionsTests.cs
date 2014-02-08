using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ISurfingbirdSurfButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ISurfingbirdSurfButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Layout(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdSurfButtonWidgetExtensions.Layout(null, SurfingbirdSurfButtonLayout.Common));

      new SurfingbirdSurfButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Layout(SurfingbirdSurfButtonLayout.Common), widget));
        Assert.True(widget.Field("layout").To<string>() == "common");
      });
      new SurfingbirdSurfButtonWidget().With(widget => Assert.True(widget.Layout(SurfingbirdSurfButtonLayout.Micro).Field("layout").To<string>() == "micro"));
      new SurfingbirdSurfButtonWidget().With(widget => Assert.True(widget.Layout(SurfingbirdSurfButtonLayout.Vertical).Field("layout").To<string>() == "vert"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Width(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdSurfButtonWidgetExtensions.Height(null, 1));

      new SurfingbirdSurfButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.True(widget.Field("width").To<string>() == "1");
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Height(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdSurfButtonWidgetExtensions.Height(null, 1));

      new SurfingbirdSurfButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.True(widget.Field("height").To<string>() == "1");
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Color(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonColor)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdSurfButtonWidgetExtensions.Color(null, SurfingbirdSurfButtonColor.Blue));

      new SurfingbirdSurfButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Color(SurfingbirdSurfButtonColor.Blue), widget));
        Assert.True(widget.Field("color").To<string>() == "blue");
      });
      new SurfingbirdSurfButtonWidget().With(widget => Assert.True(widget.Color(SurfingbirdSurfButtonColor.Gray).Field("color").To<string>() == "gray"));
      new SurfingbirdSurfButtonWidget().With(widget => Assert.True(widget.Color(SurfingbirdSurfButtonColor.Green).Field("color").To<string>() == "green"));
    }
  }
}