using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VimeoVideoWidget"/>.</para>
  /// </summary>
  public sealed class VimeoVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="VimeoVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VimeoVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(widget.Field("width") == null);
      Assert.True(widget.Field("height") == null);
      Assert.False(widget.Field("autoPlay").To<bool>());
      Assert.False(widget.Field("loop").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Id(string.Empty));

      var widget = new VimeoVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Width(string.Empty));

      var widget = new VimeoVideoWidget();
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Height(string.Empty));

      var widget = new VimeoVideoWidget();
      Assert.True(widget.Field("height") == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.AutoPlay(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AutoPlay_Method()
    {
      var widget = new VimeoVideoWidget();
      Assert.False(widget.Field("autoPlay").To<bool>());
      Assert.True(ReferenceEquals(widget.AutoPlay(), widget));
      Assert.True(widget.Field("autoPlay").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Loop(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Loop_Method()
    {
      var widget = new VimeoVideoWidget();
      Assert.False(widget.Field("loop").To<bool>());
      Assert.True(ReferenceEquals(widget.Loop(), widget));
      Assert.True(widget.Field("loop").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Id("id").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Id("id").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Height("height").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Id("id").Height("height").Width("width").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://player.vimeo.com/video/id?badge=0"" webkitallowfullscreen=""true"" width=""width""></iframe>");
      Assert.True(new StringWriter().With(writer => new VimeoVideoWidget().Id("id").Height("height").Width("width").AutoPlay().Loop().Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://player.vimeo.com/video/id?badge=0&amp;autoplay=1&amp;loop=1"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}