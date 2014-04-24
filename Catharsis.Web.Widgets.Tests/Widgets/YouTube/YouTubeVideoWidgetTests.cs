using System;
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
    /// </summary>
    /// <seealso cref="YouTubeVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YouTubeVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.False(widget.Field("privateMode").To<bool>());
      Assert.False(widget.Field("secureMode").To<bool>());
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
      Assert.Equal("id", widget.Field("id").To<string>());
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
      Assert.Equal("width", widget.Field("width").To<string>());
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
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.PrivateMode(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PrivateMode_Method()
    {
      var widget = new YouTubeVideoWidget();
      Assert.False(widget.Field("privateMode").To<bool>());
      Assert.True(ReferenceEquals(widget.PrivateMode(), widget));
      Assert.True(widget.Field("privateMode").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.SecureMode(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void SecureMode_Method()
    {
      var widget = new YouTubeVideoWidget();
      Assert.False(widget.Field("secureMode").To<bool>());
      Assert.True(ReferenceEquals(widget.SecureMode(), widget));
      Assert.True(widget.Field("secureMode").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YouTubeVideoWidget().ToString());
      Assert.Equal(string.Empty, new YouTubeVideoWidget().Id("id").Height("height").ToString());
      Assert.Equal(string.Empty, new YouTubeVideoWidget().Id("id").Width("width").ToString());
      Assert.Equal(string.Empty, new YouTubeVideoWidget().Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://www.youtube.com/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>", new YouTubeVideoWidget().Id("id").Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://www.youtube-nocookie.com/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>", new YouTubeVideoWidget().Id("id").Height("height").Width("width").PrivateMode().SecureMode().ToString());
    }
  }
}