using System;
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
    /// </summary>
    /// <seealso cref="FacebookFollowButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("faces"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("kidsMode"));
      Assert.Null(widget.Field("layout"));
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("width"));
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
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
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
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.KidsMode(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void KidsMode_Method()
    {
      var widget = new FacebookFollowButtonWidget();
      Assert.Null(widget.Field("kidsMode"));
      Assert.True(ReferenceEquals(widget.KidsMode(), widget));
      Assert.True(widget.Field("kidsMode").To<bool>());
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
      Assert.Equal("layout", widget.Field("layout").To<string>());
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
      Assert.Equal("url", widget.Field("url").To<string>());
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
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookFollowButtonWidget().ToString());
      Assert.Equal(@"<div class=""fb-follow"" data-href=""url""></div>", new FacebookFollowButtonWidget().Url("url").ToString());
      Assert.Equal(@"<div class=""fb-follow"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-show-faces=""true"" data-width=""width""></div>", new FacebookFollowButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode().Layout(FacebookButtonLayout.BoxCount).Faces().Width("width").Height("height").ToString());
    }
  }
}