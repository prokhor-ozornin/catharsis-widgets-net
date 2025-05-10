using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using AutoFixture;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IShare42PanelWidgetExtensions"/>.</para>
/// </summary>
public sealed class IShare42PanelWidgetExtensionsTest : Test
{
  private IShare42PanelWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IShare42PanelWidgetExtensionsTest() => Widget = Fixture.Create<IShare42PanelWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Horizontal(IShare42PanelWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Horizontal_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IShare42PanelWidgetExtensions.Horizontal(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(Widget);
    }

    return;

    static void Test(IShare42PanelWidget widget) => widget.Horizontal().Should().BeSameAs(widget).And.Subject.GetPropertyValue<Share42PanelDirection>("DirectionValue").Should().Be(Share42PanelDirection.Horizontal);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Size(IShare42PanelWidget, Share42PanelSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IShare42PanelWidgetExtensions.Size(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { byte.MinValue, byte.MaxValue, Fixture.Create<byte>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte size, IShare42PanelWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Vertical(IShare42PanelWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vertical_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IShare42PanelWidgetExtensions.Vertical(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(Widget);
    }

    return;

    static void Test(IShare42PanelWidget widget) => widget.Vertical().Should().BeSameAs(widget).And.Subject.GetPropertyValue<Share42PanelDirection>("DirectionValue").Should().Be(Share42PanelDirection.Vertical);
  }
}