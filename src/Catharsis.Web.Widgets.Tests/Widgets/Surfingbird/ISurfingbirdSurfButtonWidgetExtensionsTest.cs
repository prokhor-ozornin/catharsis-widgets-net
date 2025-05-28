using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISurfingbirdSurfButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ISurfingbirdSurfButtonWidgetExtensionsTest : Test
{
  private ISurfingbirdSurfButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ISurfingbirdSurfButtonWidgetExtensionsTest() => Widget = Fixture<ISurfingbirdSurfButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Layout(ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(SurfingbirdSurfButtonLayout.Micro, "micro", Widget);
      Test(SurfingbirdSurfButtonLayout.Vertical, "vert", Widget);
      Test(SurfingbirdSurfButtonLayout.Common, "common", Widget);
    }

    return;

    static void Test(SurfingbirdSurfButtonLayout layout, string value, ISurfingbirdSurfButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Width(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, ISurfingbirdSurfButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdSurfButtonWidgetExtensions.Height(ISurfingbirdSurfButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISurfingbirdSurfButtonWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, ISurfingbirdSurfButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
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

      Enum.GetValues<SurfingbirdSurfButtonColor>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(SurfingbirdSurfButtonColor color, ISurfingbirdSurfButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color.ToString().ToLowerInvariant());
  }
}