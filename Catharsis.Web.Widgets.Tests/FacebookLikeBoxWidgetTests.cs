using System;
using System.IO;
using Catharsis.Commons;
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
    ///   <seealso cref="FacebookLikeBoxWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("wall"));
      Assert.Null(widget.Field("header"));
      Assert.Null(widget.Field("border"));
      Assert.Null(widget.Field("faces"));
      Assert.Null(widget.Field("stream"));
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
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
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
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
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
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.True(widget.Field("colorScheme").To<string>() == "colorScheme");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Wall(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Wall_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("wall"));
      Assert.True(ReferenceEquals(widget.Wall(), widget));
      Assert.True(widget.Field("wall").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Header(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("header"));
      Assert.True(ReferenceEquals(widget.Header(), widget));
      Assert.True(widget.Field("header").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Border(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Border_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("border"));
      Assert.True(ReferenceEquals(widget.Border(), widget));
      Assert.True(widget.Field("border").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("faces"));
      Assert.True(ReferenceEquals(widget.Faces(), widget));
      Assert.True(widget.Field("faces").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Stream(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Stream_Method()
    {
      var widget = new FacebookLikeBoxWidget();
      Assert.Null(widget.Field("stream"));
      Assert.True(ReferenceEquals(widget.Stream(), widget));
      Assert.True(widget.Field("stream").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeBoxWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new FacebookLikeBoxWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Write(writer)).ToString() == @"<div class=""fb-like-box"" data-href=""https://www.facebook.com/pages/Clear-Words/515749945120070""></div>");
      Assert.True(new StringWriter().With(writer => new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Wall().Header().Border().Faces().Stream().Write(writer)).ToString() == @"<div class=""fb-like-box"" data-colorscheme=""dark"" data-force-wall=""true"" data-header=""true"" data-height=""height"" data-href=""https://www.facebook.com/pages/Clear-Words/515749945120070"" data-show-border=""true"" data-show-faces=""true"" data-stream=""true"" data-width=""width""></div>");
    }
  }
}