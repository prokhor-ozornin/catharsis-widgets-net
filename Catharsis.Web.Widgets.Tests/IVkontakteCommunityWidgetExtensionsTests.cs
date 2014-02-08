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

      new VkontakteCommunityWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Mode(VkontakteCommunityMode.Participants), widget));
        Assert.True(widget.Field("mode").To<byte>() == 0);
      });
      new VkontakteCommunityWidget().With(widget => widget.Mode(VkontakteCommunityMode.Title).Field("mode").To<byte>() == 1);
      new VkontakteCommunityWidget().With(widget => widget.Mode(VkontakteCommunityMode.News).Field("mode").To<byte>() == 2);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Width(IVkontakteCommunityWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommunityWidgetExtensions.Width(null, 0));

      new VkontakteCommunityWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.True(widget.Field("width").To<string>() == "1");
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommunityWidgetExtensions.Height(IVkontakteCommunityWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommunityWidgetExtensions.Height(null, 0));

      new VkontakteCommunityWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.True(widget.Field("height").To<string>() == "1");
      });
    }
  }
}