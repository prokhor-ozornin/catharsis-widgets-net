using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteCommunityWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteCommunityWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Mode(IVkontakteCommunityWidget, VkontakteCommunityMode)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mode_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommunityWidgetExtensions.Mode(null, VkontakteCommunityMode.News));

      new VkontakteCommunityWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Mode(VkontakteCommunityMode.Participants), widget));
        Assert.Equal(0, widget.Mode());
      });
      Assert.Equal(1, new VkontakteCommunityWidget().Do(widget => widget.Mode(VkontakteCommunityMode.Title).Mode()));
      Assert.Equal(2, new VkontakteCommunityWidget().Do(widget => widget.Mode(VkontakteCommunityMode.News).Mode()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Width(IVkontakteCommunityWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommunityWidgetExtensions.Width(null, 0));

      new VkontakteCommunityWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommunityWidgetExtensions.Height(null, 0));

      new VkontakteCommunityWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Height());
      });
    }
  }
}