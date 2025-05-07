using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VideoJSPlayerWidget"/>.</para>
/// </summary>
public sealed class VideoJSPlayerWidgetTest : Test
{
  private IVideoJSPlayerWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VideoJSPlayerWidgetTest() => Widget = Fixture.Create<IVideoJSPlayerWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VideoJSPlayerWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VideoJSPlayerWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVideoJSPlayerWidget>();

    using (new AssertionScope())
    {
      var widget = new VideoJSPlayerWidget();
      widget.GetPropertyValue<string>("ExtraValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<IEnumerable<(string ContentType, string Url)>>("VideosValue").Should().BeEmpty();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Extra(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Extra_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Extra(null)).ThrowExactly<ArgumentNullException>().WithParameterName("extra");
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Extra(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("extra");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string extra, IVideoJSPlayerWidget widget) => widget.Extra(extra).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ExtraValue").Should().Be(extra);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string width, IVideoJSPlayerWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string height, IVideoJSPlayerWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Videos_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VideoJSPlayerWidget().Videos(null)).ThrowExactly<ArgumentNullException>().WithParameterName("videos");

      new[] { Enumerable.Empty<(string Url, string ContentType)>(), [("url", "contentType")] }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(IEnumerable<(string Url, string ContentType)> videos, IVideoJSPlayerWidget widget) => widget.Videos(videos).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<(string ContentType, string Url)>>("VideosValue").Should().Equal(videos);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VideoJSPlayerWidget());
      Validate(Fixture.Create<IVideoJSPlayerWidget>());
    }

    return;

    static void Validate(IVideoJSPlayerWidget original)
    {
      var clone = original.Clone<IVideoJSPlayerWidget>();

      clone.GetPropertyValue<string>("ExtraValue").Should().Be(original.GetPropertyValue<string>("ExtraValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<IEnumerable<(string ContentType, string Url)>>("VideosValue").Should().Equal(original.GetPropertyValue<IEnumerable<(string ContentType, string Url)>>("VideosValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    var videos = new[] { ("http://vjs.zencdn.net/v/oceans.mp4", "video/mp4"), ("http://vjs.zencdn.net/v/oceans.webm", "video/webm") };

    using (new AssertionScope())
    {
      Validate(new VideoJSPlayerWidget());
      Validate(new VideoJSPlayerWidget().Width("width"));
      Validate(new VideoJSPlayerWidget().Height("height"));
      Validate(new VideoJSPlayerWidget().Width("width").Height("height"));
      Validate(new VideoJSPlayerWidget().Videos(videos));
      Validate(new VideoJSPlayerWidget().Videos(videos).Width("width"));
      Validate(new VideoJSPlayerWidget().Videos(videos).Height("height"));
      Validate(new VideoJSPlayerWidget().Videos(videos).Width("width").Height("height").Extra("""<track kind="captions" src="http://www.videojs.com/vtt/captions.vtt" srclang="en" label="English"></track>"""), """<video class="video-js vjs-default-skin" controls="controls" data-setup="{}" height="height" preload="auto" width="width"><source src="http://vjs.zencdn.net/v/oceans.mp4" type="video/mp4"></source><source src="http://vjs.zencdn.net/v/oceans.webm" type="video/webm"></source><track kind="captions" src="http://www.videojs.com/vtt/captions.vtt" srclang="en" label="English"></track></video>""");
      Validate(Fixture.Create<IVideoJSPlayerWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      if (html.IsUnset())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}