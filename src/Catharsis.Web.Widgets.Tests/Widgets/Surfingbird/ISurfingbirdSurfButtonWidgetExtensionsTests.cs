using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISurfingbirdSurfButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ISurfingbirdSurfButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Layout(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SurfingbirdSurfButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Layout(SurfingbirdSurfButtonLayout.Common), widget));
      Assert.Equal("common", widget.Layout());
    });
    new SurfingbirdSurfButtonWidget().With(widget => Assert.Equal("micro", widget.Layout(SurfingbirdSurfButtonLayout.Micro).Layout()));
    new SurfingbirdSurfButtonWidget().With(widget => Assert.Equal("vert", widget.Layout(SurfingbirdSurfButtonLayout.Vertical).Layout()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Width(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SurfingbirdSurfButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Width(1), widget));
      Assert.Equal("1", widget.Width());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Height(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SurfingbirdSurfButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Height(1), widget));
      Assert.Equal("1", widget.Height());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Color(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonColor)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Color(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SurfingbirdSurfButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Color(SurfingbirdSurfButtonColor.Blue), widget));
      Assert.Equal("blue", widget.Color());
    });
    new SurfingbirdSurfButtonWidget().With(widget => Assert.Equal("gray", widget.Color(SurfingbirdSurfButtonColor.Gray).Color()));
    new SurfingbirdSurfButtonWidget().With(widget => Assert.Equal("green", widget.Color(SurfingbirdSurfButtonColor.Green).Color()));
  }
}