using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommunityWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteCommunityWidgetExtensions"/>
public sealed class IVkontakteCommunityWidgetExtensionsTest : Test
{
  private IVkontakteCommunityWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteCommunityWidgetExtensionsTest() => Widget = Fixture<IVkontakteCommunityWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Mode(IVkontakteCommunityWidget, VkontakteCommunityMode)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Mode(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<VkontakteCommunityMode>().ForEach(mode => Test(mode, Widget));
    }

    return;

    static void Test(VkontakteCommunityMode mode, IVkontakteCommunityWidget widget) => widget.Mode(mode).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("ModeValue").Should().Be((byte) mode);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Width(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IVkontakteCommunityWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Height(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(short height, IVkontakteCommunityWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }
}