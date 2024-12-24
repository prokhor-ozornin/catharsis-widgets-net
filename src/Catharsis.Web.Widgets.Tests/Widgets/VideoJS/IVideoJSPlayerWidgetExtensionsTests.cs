using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVideoJSPlayerWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVideoJSPlayerWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Width(IVideoJSPlayerWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

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
    AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

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
    AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Videos(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Videos(new VideoJSPlayerWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("videos");

    new VideoJSPlayerWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Videos(Enumerable.Empty<IMediaSource>()), widget));
      Assert.False(widget.Videos().Any());
    });

    new VideoJSPlayerWidget().With(widget => Assert.True(widget.Videos(new[] { new MediaSource("url", "contentType") }).Videos().SequenceEqual(new[] { new MediaSource("url", "contentType") })));
  }
}