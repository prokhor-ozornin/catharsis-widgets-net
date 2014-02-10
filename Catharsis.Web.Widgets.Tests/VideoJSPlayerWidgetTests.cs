﻿using System;
using System.Collections.Generic;
using System.IO;
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
    ///   <seealso cref="VideoJSPlayerWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VideoJSPlayerWidget();
      Assert.True(widget.Field("width") == null);
      Assert.True(widget.Field("height") == null);
      Assert.False(widget.Field("videos").To<IEnumerable<IMediaSource>>().Any());
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
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
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
      Assert.True(widget.Field("height") == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
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
    ///   <para>Performs testing of <see cref="VideoJSPlayerWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VideoJSPlayerWidget().Write(null));

      var videos = new[] { new MediaSource("http://vjs.zencdn.net/v/oceans.mp4", VideoContentTypes.MP4), new MediaSource("http://vjs.zencdn.net/v/oceans.webm", VideoContentTypes.WebM) };

      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Videos(videos).Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Videos(videos).Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Videos(videos).Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VideoJSPlayerWidget().Videos(videos).Width("width").Height("height").HtmlBody(@"<track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track>").Write(writer)).ToString() == @"<video class=""video-js vjs-default-skin"" controls=""controls"" data-setup=""{}"" height=""height"" preload=""auto"" width=""width""><source src=""http://vjs.zencdn.net/v/oceans.mp4"" type=""video/mp4""></source><source src=""http://vjs.zencdn.net/v/oceans.webm"" type=""video/webm""></source><track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track></video>");
    }
  }
}