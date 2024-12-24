using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGooglePlusOneButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGooglePlusOneButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Width(IGooglePlusOneButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new GooglePlusOneButtonWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Size(IGooglePlusOneButtonWidget, GooglePlusOneButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("medium", new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Medium).Size());
    Assert.Equal("small", new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Small).Size());
    Assert.Equal("standard", new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Standard).Size());
    Assert.Equal("tall", new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Tall).Size());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Alignment(IGooglePlusOneButtonWidget, GooglePlusOneButtonAlignment)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Alignment(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("left", new GooglePlusOneButtonWidget().Alignment(GooglePlusOneButtonAlignment.Left).Alignment());
    Assert.Equal("right", new GooglePlusOneButtonWidget().Alignment(GooglePlusOneButtonAlignment.Right).Alignment());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Annotation(IGooglePlusOneButtonWidget, GooglePlusOneButtonAnnotation)"/> method.</para>
  /// </summary>
  [Fact]
  public void Annotation_Method()
  {
    AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Annotation(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("bubble", new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.Bubble).Annotation());
    Assert.Equal("inline", new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.Inline).Annotation());
    Assert.Equal("none", new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.None).Annotation());
  }
}