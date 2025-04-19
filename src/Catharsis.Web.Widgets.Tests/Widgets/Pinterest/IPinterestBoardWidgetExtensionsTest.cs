using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestBoardWidgetExtensions"/>.</para>
/// </summary>
public sealed class IPinterestBoardWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Height(IPinterestBoardWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestBoardWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short height, IPinterestBoardWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Width(IPinterestBoardWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestBoardWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IPinterestBoardWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Header(IPinterestBoardWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Header(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestProfileWidget().With(Validate);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Header().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageProperty").Should().Be("115");
      widget.GetPropertyValue<string>("HeightProperty").Should().Be("120");
      widget.GetPropertyValue<string>("WidthProperty").Should().Be("900");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Image(IPinterestBoardWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Image(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestBoardWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IPinterestBoardWidget widget) => widget.Image(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Sidebar(IPinterestBoardWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sidebar_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Sidebar(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestProfileWidget().With(Validate);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Sidebar().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageProperty").Should().Be("60");
      widget.GetPropertyValue<string>("HeightProperty").Should().Be("800");
      widget.GetPropertyValue<string>("WidthProperty").Should().Be("150");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Square(IPinterestBoardWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Square_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Square(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new PinterestProfileWidget().With(Validate);
    }

    return;

    static void Validate(IPinterestProfileWidget widget)
    {
      widget.Square().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageProperty").Should().Be("80");
      widget.GetPropertyValue<string>("HeightProperty").Should().Be("320");
      widget.GetPropertyValue<string>("WidthProperty").Should().Be("400");
    }
  }
}