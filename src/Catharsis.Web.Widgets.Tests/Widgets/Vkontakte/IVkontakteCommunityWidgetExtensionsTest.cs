using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommunityWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteCommunityWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Mode(IVkontakteCommunityWidget, VkontakteCommunityMode)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Mode(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteCommunityWidget();
      Enum.GetValues<VkontakteCommunityMode>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteCommunityMode mode, IVkontakteCommunityWidget widget)
    {
      widget.Mode(mode).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("ModeProperty").Should().Be((byte) mode);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Width(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteCommunityWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IVkontakteCommunityWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Height(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteCommunityWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, IVkontakteCommunityWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
    }
  }
}