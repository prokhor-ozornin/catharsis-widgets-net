using System;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteCommentsWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteCommentsWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Limit(IVkontakteCommentsWidget, VkontakteCommentsLimit)"/> method.</para>
    /// </summary>
    [Fact]
    public void Limit_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommentsWidgetExtensions.Limit(null, VkontakteCommentsLimit.Limit10));

      new VkontakteCommentsWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Limit(1), widget));
        Assert.Equal(1, widget.Limit());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Attach(IVkontakteCommentsWidget, VkontakteCommentsAttach[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Attach_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommentsWidgetExtensions.Attach(null, VkontakteCommentsAttach.All));

      new VkontakteCommentsWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Attach("first", "second"), widget));
        var attach = widget.Attach().ToArray();
        Assert.Equal(2, attach.Count());
        Assert.True(attach.SequenceEqual(new[] { "first", "second" }));
      });
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.All).Do(widget => Assert.Equal("*", widget.Attach().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Audio).Do(widget => Assert.Equal("audio", widget.Attach().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Graffiti).Do(widget => Assert.Equal("graffiti", widget.Attach().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Link).Do(widget => Assert.Equal("link", widget.Attach().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Photo).Do(widget => Assert.Equal("photo", widget.Attach().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Video).Do(widget => Assert.Equal("video", widget.Attach().Single()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Width(IVkontakteCommentsWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommentsWidgetExtensions.Width(null, 0));

      new VkontakteCommentsWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }
  }
}