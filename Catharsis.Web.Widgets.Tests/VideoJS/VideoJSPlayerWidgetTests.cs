using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VideoJSPlayerWidget"/>.</para>
  /// </summary>
  public sealed class VideoJSPlayerWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VideoJSPlayerWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VideoJSPlayerWidget();
      Assert.Null(widget.Field("extra"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.False(widget.Field("videos").To<IEnumerable<IMediaSource>>().Any());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Extra(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Extra_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Width(string.Empty));

      var widget = new VideoJSPlayerWidget();
      Assert.Null(widget.Field("extra"));
      Assert.True(ReferenceEquals(widget.Extra("extra"), widget));
      Assert.Equal("extra", widget.Field("extra").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Width(string.Empty));

      var widget = new VideoJSPlayerWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new VideoJSPlayerWidget().Height(string.Empty));

      var widget = new VideoJSPlayerWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Videos(IEnumerable{IMediaSource})"/> method.</para>
    /// </summary>
    [Fact]
    public void Videos_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Videos(null));

      var widget = new VideoJSPlayerWidget();
      Assert.False(widget.Field("videos").To<IEnumerable<IMediaSource>>().Any());
      Assert.True(ReferenceEquals(widget.Videos(new MediaSource("url", "contentType")), widget));
      Assert.True(widget.Field("videos").To<IEnumerable<IMediaSource>>().SequenceEqual(new [] { new MediaSource("url", "contentType") }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var videos = new[] { new MediaSource("http://vjs.zencdn.net/v/oceans.mp4", VideoContentTypes.MP4), new MediaSource("http://vjs.zencdn.net/v/oceans.webm", VideoContentTypes.WebM) };

      Assert.Equal(string.Empty, new VideoJSPlayerWidget().ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Width("width").ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Height("height").ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Width("width").Height("height").ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).Width("width").ToString());
      Assert.Equal(string.Empty, new VideoJSPlayerWidget().Videos(videos).Height("height").ToString());
      Assert.Equal(@"<video class=""video-js vjs-default-skin"" controls=""controls"" data-setup=""{}"" height=""height"" preload=""auto"" width=""width""><source src=""http://vjs.zencdn.net/v/oceans.mp4"" type=""video/mp4""></source><source src=""http://vjs.zencdn.net/v/oceans.webm"" type=""video/webm""></source><track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track></video>", new VideoJSPlayerWidget().Videos(videos).Width("width").Height("height").Extra(@"<track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track>").ToString());
    }
  }
}