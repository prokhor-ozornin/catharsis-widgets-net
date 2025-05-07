using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestProfileWidgetExtensions"/>.</para>
/// </summary>
public sealed class IPinterestProfileWidgetExtensionsTest : Test
{
  private IPinterestProfileWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IPinterestProfileWidgetExtensionsTest() => Widget = Fixture.Create<IPinterestProfileWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Height(IPinterestProfileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short height, IPinterestProfileWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Width(IPinterestProfileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IPinterestProfileWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Header(IPinterestProfileWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Header(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Header().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("115");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("120");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("900");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Image(IPinterestProfileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Image(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IPinterestProfileWidget widget) => widget.Image(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Sidebar(IPinterestProfileWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sidebar_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Sidebar(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Sidebar().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("60");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("800");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("150");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestProfileWidgetExtensions.Square(IPinterestProfileWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Square_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestProfileWidgetExtensions.Square(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Square().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("80");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("320");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("400");
    }
  }
}