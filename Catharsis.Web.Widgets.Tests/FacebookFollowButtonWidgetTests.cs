using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookFollowButtonWidget"/>.</para>
  /// </summary>
  public sealed class FacebookFollowButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="FacebookFollowButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("kids"));
      Assert.Null(widget.Field("layout"));
      Assert.Null(widget.Field("faces"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookFollowButtonWidget().Url(string.Empty));

      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookFollowButtonWidget().Width(string.Empty));

      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookFollowButtonWidget().Height(string.Empty));

      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookFollowButtonWidget().ColorScheme(string.Empty));

      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.True(widget.Field("colorScheme").To<string>() == "colorScheme");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Kids"/> method.</para>
    /// </summary>
    [Fact]
    public void Kids_Method()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("kids"));
      Assert.True(ReferenceEquals(widget.Kids(), widget));
      Assert.True(widget.Field("kids").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new FacebookFollowButtonWidget().Layout(string.Empty));

      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("layout"));
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("faces"));
      Assert.True(ReferenceEquals(widget.Faces(), widget));
      Assert.True(widget.Field("faces").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFollowButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new FacebookFollowButtonWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookFollowButtonWidget().Url("url").Write(writer)).ToString() == @"<div class=""fb-follow"" data-href=""url""></div>");
      Assert.True(new StringWriter().With(writer => new FacebookFollowButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).Kids().Layout(FacebookButtonLayout.BoxCount).Faces().Width("width").Height("height").Write(writer)).ToString() == @"<div class=""fb-follow"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-show-faces=""true"" data-width=""width""></div>");
    }
  }
}