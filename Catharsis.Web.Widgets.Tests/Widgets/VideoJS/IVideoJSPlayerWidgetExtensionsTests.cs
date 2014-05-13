using System;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVideoJSPlayerWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVideoJSPlayerWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Width(IVideoJSPlayerWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVideoJSPlayerWidgetExtensions.Width(null, 0));

      new VideoJSPlayerWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Height(IVideoJSPlayerWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVideoJSPlayerWidgetExtensions.Height(null, 0));

      new VideoJSPlayerWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Height());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Videos(IVideoJSPlayerWidget, IMediaSource[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Videos_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVideoJSPlayerWidgetExtensions.Videos(null, new IMediaSource[] {}));
      Assert.Throws<ArgumentNullException>(() => IVideoJSPlayerWidgetExtensions.Videos(new VideoJSPlayerWidget(), null));

      new VideoJSPlayerWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Videos(Enumerable.Empty<IMediaSource>()), widget));
        Assert.False(widget.Videos().Any());
      });

      new VideoJSPlayerWidget().With(widget => Assert.True(widget.Videos(new[] { new MediaSource("url", "contentType") }).Videos().SequenceEqual(new[] { new MediaSource("url", "contentType") })));
    }
  }
}