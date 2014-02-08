using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IGooglePlusOneButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IGooglePlusOneButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Width(IGooglePlusOneButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGooglePlusOneButtonWidgetExtensions.Width(null, 0));

      Assert.True(new GooglePlusOneButtonWidget().Width(1).Field("width").To<string>() == "1");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Size(IGooglePlusOneButtonWidget, GooglePlusOneButtonSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGooglePlusOneButtonWidgetExtensions.Size(null, GooglePlusOneButtonSize.Standard));

      Assert.True(new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Medium).Field("size").To<string>() == "medium");
      Assert.True(new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Small).Field("size").To<string>() == "small");
      Assert.True(new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Standard).Field("size").To<string>() == "standard");
      Assert.True(new GooglePlusOneButtonWidget().Size(GooglePlusOneButtonSize.Tall).Field("size").To<string>() == "tall");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Alignment(IGooglePlusOneButtonWidget, GooglePlusOneButtonAlignment)"/> method.</para>
    /// </summary>
    [Fact]
    public void Alignment_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGooglePlusOneButtonWidgetExtensions.Alignment(null, GooglePlusOneButtonAlignment.Left));

      Assert.True(new GooglePlusOneButtonWidget().Alignment(GooglePlusOneButtonAlignment.Left).Field("alignment").To<string>() == "left");
      Assert.True(new GooglePlusOneButtonWidget().Alignment(GooglePlusOneButtonAlignment.Right).Field("alignment").To<string>() == "right");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Annotation(IGooglePlusOneButtonWidget, GooglePlusOneButtonAnnotation)"/> method.</para>
    /// </summary>
    [Fact]
    public void Annotation_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGooglePlusOneButtonWidgetExtensions.Annotation(null, GooglePlusOneButtonAnnotation.None));

      Assert.True(new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.Bubble).Field("annotation").To<string>() == "bubble");
      Assert.True(new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.Inline).Field("annotation").To<string>() == "inline");
      Assert.True(new GooglePlusOneButtonWidget().Annotation(GooglePlusOneButtonAnnotation.None).Field("annotation").To<string>() == "none");
    }
  }
}