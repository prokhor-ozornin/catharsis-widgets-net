using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YouTubeVideoWidget"/>.</para>
  /// </summary>
  public sealed class YouTubeVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="YouTubeVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new YouTubeVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.False(widget.Field("private").To<bool>());
      Assert.False(widget.Field("secure").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Id(string.Empty));

      var widget = new YouTubeVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Width(string.Empty));

      var widget = new YouTubeVideoWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Height(string.Empty));

      var widget = new YouTubeVideoWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Private(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Private_Method()
    {
      var widget = new YouTubeVideoWidget();
      Assert.False(widget.Field("private").To<bool>());
      Assert.True(ReferenceEquals(widget.Private(), widget));
      Assert.True(widget.Field("private").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Secure(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Secure_Method()
    {
      var widget = new YouTubeVideoWidget();
      Assert.False(widget.Field("secure").To<bool>());
      Assert.True(ReferenceEquals(widget.Secure(), widget));
      Assert.True(widget.Field("secure").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Id("id").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Id("id").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Height("height").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Id("id").Height("height").Width("width").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://www.youtube.com/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
      Assert.True(new StringWriter().With(writer => new YouTubeVideoWidget().Id("id").Height("height").Width("width").Private().Secure().Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://www.youtube-nocookie.com/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}