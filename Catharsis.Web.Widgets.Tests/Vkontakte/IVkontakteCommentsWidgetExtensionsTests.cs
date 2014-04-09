using System;
using System.Collections.Generic;
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

      new VkontakteCommentsWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Limit(1), widget));
        Assert.Equal(1, widget.Field("limit").To<byte>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Attach(IVkontakteCommentsWidget, VkontakteCommentsAttach[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Attach_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommentsWidgetExtensions.Attach(null, VkontakteCommentsAttach.All));

      new VkontakteCommentsWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Attach("first", "second"), widget));
        var attach = widget.Field("attach").To<IEnumerable<string>>().ToArray();
        Assert.Equal(2, attach.Count());
        Assert.True(attach.SequenceEqual(new[] { "first", "second" }));
      });
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.All).With(widget => Assert.Equal("*", widget.Field("attach").To<IEnumerable<string>>().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Audio).With(widget => Assert.Equal("audio", widget.Field("attach").To<IEnumerable<string>>().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Graffiti).With(widget => Assert.Equal("graffiti", widget.Field("attach").To<IEnumerable<string>>().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Link).With(widget => Assert.Equal("link", widget.Field("attach").To<IEnumerable<string>>().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Photo).With(widget => Assert.Equal("photo", widget.Field("attach").To<IEnumerable<string>>().Single()));
      new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Video).With(widget => Assert.Equal("video", widget.Field("attach").To<IEnumerable<string>>().Single()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Width(IVkontakteCommentsWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteCommentsWidgetExtensions.Width(null, 0));

      new VkontakteCommentsWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Field("width").To<string>());
      });
    }
  }
}