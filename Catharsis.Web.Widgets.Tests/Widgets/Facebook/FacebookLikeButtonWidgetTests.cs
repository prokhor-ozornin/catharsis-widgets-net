using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookLikeButtonWidget"/>.</para>
  /// </summary>
  public sealed class FacebookLikeButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookLikeButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Faces());
      Assert.Null(widget.KidsMode());
      Assert.Null(widget.Layout());
      Assert.Null(widget.TrackLabel());
      Assert.Null(widget.Url());
      Assert.Null(widget.Verb());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().ColorScheme(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Faces());
      Assert.True(ReferenceEquals(widget.Faces(true), widget));
      Assert.True(widget.Faces().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.KidsMode(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void KidsMode_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.KidsMode());
      Assert.True(ReferenceEquals(widget.KidsMode(true), widget));
      Assert.True(widget.KidsMode().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Layout(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Layout());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Layout());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.TrackLabel(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackLabel_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().TrackLabel(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().TrackLabel(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.TrackLabel());
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.Equal("trackLabel", widget.TrackLabel());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Url(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Verb(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Verb(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Verb(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Verb());
      Assert.True(ReferenceEquals(widget.Verb("verb"), widget));
      Assert.Equal("verb", widget.Verb());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Width(string.Empty));

      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""fb-like""></div>", new FacebookLikeButtonWidget().ToString());
      Assert.Equal(@"<div class=""fb-like"" data-href=""url""></div>", new FacebookLikeButtonWidget().Url("url").ToString());
      Assert.Equal(@"<div class=""fb-like"" data-action=""recommend"" data-colorscheme=""dark"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-ref=""trackLabel"" data-show-faces=""true"" data-width=""width""></div>", new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).ColorScheme(FacebookColorScheme.Dark).Url("url").KidsMode(true).Layout(FacebookButtonLayout.BoxCount).TrackLabel("trackLabel").Faces(true).Width("width").ToString());
    }
  }
}