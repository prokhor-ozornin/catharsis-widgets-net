using System;
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
    /// </summary>
    /// <seealso cref="VimeoVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VimeoVideoWidget();
      Assert.Null(widget.Id());
      Assert.Null(widget.Width());
      Assert.Null(widget.Height());
      Assert.False(widget.AutoPlay());
      Assert.False(widget.Loop());
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
      Assert.Null(widget.Id());
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Id());
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
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
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
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.AutoPlay(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AutoPlay_Method()
    {
      var widget = new VimeoVideoWidget();
      Assert.False(widget.AutoPlay());
      Assert.True(ReferenceEquals(widget.AutoPlay(true), widget));
      Assert.True(widget.AutoPlay());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.Loop(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Loop_Method()
    {
      var widget = new VimeoVideoWidget();
      Assert.False(widget.Loop());
      Assert.True(ReferenceEquals(widget.Loop(true), widget));
      Assert.True(widget.Loop());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VimeoVideoWidget().ToString());
      Assert.Equal(string.Empty, new VimeoVideoWidget().Id("id").Height("height").ToString());
      Assert.Equal(string.Empty, new VimeoVideoWidget().Id("id").Width("width").ToString());
      Assert.Equal(string.Empty, new VimeoVideoWidget().Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://player.vimeo.com/video/id?badge=0"" webkitallowfullscreen=""true"" width=""width""></iframe>", new VimeoVideoWidget().Id("id").Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""https://player.vimeo.com/video/id?badge=0&amp;autoplay=1&amp;loop=1"" webkitallowfullscreen=""true"" width=""width""></iframe>", new VimeoVideoWidget().Id("id").Height("height").Width("width").AutoPlay(true).Loop(true).ToString());
    }
  }
}