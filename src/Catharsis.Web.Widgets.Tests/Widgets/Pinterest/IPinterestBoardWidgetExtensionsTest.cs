using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestBoardWidgetExtensions"/>.</para>
/// </summary>
public sealed class IPinterestBoardWidgetExtensionsTest : Test
{
  private IPinterestBoardWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IPinterestBoardWidgetExtensionsTest() => Widget = Fixture.Create<IPinterestBoardWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Height(IPinterestBoardWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestBoardWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short height, IPinterestBoardWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IPinterestBoardWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
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

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestBoardWidget widget)
    {
      widget.Header().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("115");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("120");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("900");
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IPinterestBoardWidget widget) => widget.Image(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(width.ToInvariantString());
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

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestBoardWidget widget)
    {
      widget.Sidebar().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("60");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("800");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("150");
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

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestBoardWidget widget)
    {
      widget.Square().Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ImageValue").Should().Be("80");
      widget.GetPropertyValue<string>("HeightValue").Should().Be("320");
      widget.GetPropertyValue<string>("WidthValue").Should().Be("400");
    }
  }
}