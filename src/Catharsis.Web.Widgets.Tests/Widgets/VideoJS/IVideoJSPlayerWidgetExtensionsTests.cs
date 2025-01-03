using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VideoJSPlayerWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IVideoJSPlayerWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Height(IVideoJSPlayerWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VideoJSPlayerWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, IVideoJSPlayerWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height.ToInvariantString());
    }
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