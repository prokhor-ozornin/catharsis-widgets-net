using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommunityWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteCommunityWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Mode(IVkontakteCommunityWidget, VkontakteCommunityMode)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Mode(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteCommunityWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Mode(VkontakteCommunityMode.Participants), widget));
      Assert.Equal(0, widget.Mode());
    });
    Assert.Equal(1, new VkontakteCommunityWidget().With(widget => widget.Mode(VkontakteCommunityMode.Title).Mode()));
    Assert.Equal(2, new VkontakteCommunityWidget().With(widget => widget.Mode(VkontakteCommunityMode.News).Mode()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Width(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteCommunityWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Width(1), widget));
      Assert.Equal("1", widget.Width());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Height(IVkontakteCommunityWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IVkontakteCommunityWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteCommunityWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Height(1), widget));
      Assert.Equal("1", widget.Height());
    });
  }
}