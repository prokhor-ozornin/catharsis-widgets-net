using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VideoJSPlayerWidget"/>.</para>
/// </summary>
public sealed class VideoJSPlayerWidgetTests : ClassTest<VideoJSPlayerWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VideoJSPlayerWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VideoJSPlayerWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVideoJSPlayerWidget>();

    var widget = new VideoJSPlayerWidget();
    widget.Extra().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Videos().Should().BeEmpty();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Extra(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Extra_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VideoJSPlayerWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string extra, IVideoJSPlayerWidget widget)
    {
      widget.Extra(extra).Should().BeSameAs(widget);
      widget.Extra().Should().Be(extra);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VideoJSPlayerWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVideoJSPlayerWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VideoJSPlayerWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IVideoJSPlayerWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Videos(IEnumerable{IMediaSource})"/> method.</para>
  /// </summary>
  [Fact]
  public void Videos_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Videos(null));

    using (new AssertionScope())
    {
      var widget = new VideoJSPlayerWidget();
      new[] { Enumerable.Empty<IMediaSource>(), [new MediaSource("url", "contentType")] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<IMediaSource> videos, IVideoJSPlayerWidget widget)
    {
      widget.Videos(videos).Should().BeSameAs(widget);
      widget.Videos().Should().Equal(videos);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    var videos = new[] { new MediaSource("http://vjs.zencdn.net/v/oceans.mp4", VideoContentTypes.MP4), new MediaSource("http://vjs.zencdn.net/v/oceans.webm", VideoContentTypes.WebM) };

    Assert.Equal(string.Empty, new VideoJSPlayerWidget().ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Width("width").ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Height("height").ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Width("width").Height("height").ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).Width("width").ToString());
    Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).Height("height").ToString());
    Assert.Equal("""<video class="video-js vjs-default-skin" controls="controls" data-setup="{}" height="height" preload="auto" width="width"><source src="http://vjs.zencdn.net/v/oceans.mp4" type="video/mp4"></source><source src="http://vjs.zencdn.net/v/oceans.webm" type="video/webm"></source><track kind="captions" src="http://www.videojs.com/vtt/captions.vtt" srclang="en" label="English"></track></video>""", new VideoJSPlayerWidget().Videos(videos).Width("width").Height("height").Extra("""<track kind="captions" src="http://www.videojs.com/vtt/captions.vtt" srclang="en" label="English"></track>""").ToString());
  }
}