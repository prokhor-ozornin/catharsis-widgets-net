using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookLikeBoxWidget"/>.</para>
  /// </summary>
  public sealed class FacebookLikeBoxWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookLikeBoxWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Border());
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Faces());
      Assert.Null(widget.Header());
      Assert.Null(widget.Height());
      Assert.Null(widget.Stream());
      Assert.Null(widget.Url());
      Assert.Null(widget.Wall());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Border(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Border_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Border());
      Assert.True(ReferenceEquals(widget.Border(true), widget));
      Assert.True(widget.Border().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeBoxWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeBoxWidget().ColorScheme(string.Empty));

      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Faces());
      Assert.True(ReferenceEquals(widget.Faces(true), widget));
      Assert.True(widget.Faces().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Header(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Header());
      Assert.True(ReferenceEquals(widget.Header(true), widget));
      Assert.True(widget.Header().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeBoxWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeBoxWidget().Height(string.Empty));

      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Stream(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Stream_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Stream());
      Assert.True(ReferenceEquals(widget.Stream(true), widget));
      Assert.True(widget.Stream().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeBoxWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeBoxWidget().Url(string.Empty));

      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Wall(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Wall_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Wall());
      Assert.True(ReferenceEquals(widget.Wall(true), widget));
      Assert.True(widget.Wall().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeBoxWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeBoxWidget().Width(string.Empty));

      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookLikeBoxWidget().ToString());
      Assert.Equal(@"<div class=""fb-like-box"" data-href=""https://www.facebook.com/pages/Clear-Words/515749945120070""></div>", new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").ToString());
      Assert.Equal(@"<div class=""fb-like-box"" data-colorscheme=""dark"" data-force-wall=""true"" data-header=""true"" data-height=""height"" data-href=""https://www.facebook.com/pages/Clear-Words/515749945120070"" data-show-border=""true"" data-show-faces=""true"" data-stream=""true"" data-width=""width""></div>", new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Wall(true).Header(true).Border(true).Faces(true).Stream(true).ToString());
    }
  }
}