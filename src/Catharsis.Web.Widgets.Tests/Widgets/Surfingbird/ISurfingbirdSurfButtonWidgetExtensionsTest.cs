using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISurfingbirdSurfButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ISurfingbirdSurfButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Layout(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new SurfingbirdSurfButtonWidget();
      Enum.GetValues<SurfingbirdSurfButtonLayout>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(SurfingbirdSurfButtonLayout layout, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("LayoutProperty").Should().Be(layout.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Width(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Height(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Color(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonColor)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Color(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new SurfingbirdSurfButtonWidget();
      Enum.GetValues<SurfingbirdSurfButtonColor>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(SurfingbirdSurfButtonColor color, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ColorProperty").Should().Be(color.ToString().ToLowerInvariant());
    }
  }
}