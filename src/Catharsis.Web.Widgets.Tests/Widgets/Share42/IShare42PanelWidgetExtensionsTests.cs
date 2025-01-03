using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IShare42PanelWidgetExtensions"/>.</para>
/// </summary>
public sealed class IShare42PanelWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Horizontal(IShare42PanelWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Horizontal_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IShare42PanelWidgetExtensions.Horizontal(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new Share42PanelWidget();
      Validate(widget);
    }

    return;

    static void Validate(IShare42PanelWidget widget)
    {
      widget.Horizontal().Should().BeSameAs(widget);
      widget.Direction().Should().Be(Share42PanelDirection.Horizontal);
    }
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

      var widget = new Share42PanelWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte size, IShare42PanelWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be((byte) size);
    }
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

      var widget = new Share42PanelWidget();
      Validate(widget);
    }

    return;

    static void Validate(IShare42PanelWidget widget)
    {
      widget.Vertical().Should().BeSameAs(widget);
      widget.Direction().Should().Be(Share42PanelDirection.Vertical);
    }
  }
}