using System;
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
    /// </summary>
    /// <seealso cref="FacebookFollowButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Faces());
      Assert.Null(widget.Height());
      Assert.Null(widget.KidsMode());
      Assert.Null(widget.Layout());
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
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
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Faces());
      Assert.True(ReferenceEquals(widget.Faces(true), widget));
      Assert.True(widget.Faces().Value);
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
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.KidsMode(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void KidsMode_Method()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.KidsMode());
      Assert.True(ReferenceEquals(widget.KidsMode(true), widget));
      Assert.True(widget.KidsMode().Value);
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
      Assert.Null(widget.Layout());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Layout());
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
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
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
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookFollowButtonWidget().ToString());
      Assert.Equal(@"<div class=""fb-follow"" data-href=""url""></div>", new FacebookFollowButtonWidget().Url("url").ToString());
      Assert.Equal(@"<div class=""fb-follow"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-show-faces=""true"" data-width=""width""></div>", new FacebookFollowButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode(true).Layout(FacebookButtonLayout.BoxCount).Faces(true).Width("width").Height("height").ToString());
    }
  }
}