using System;
using System.IO;
using Catharsis.Commons;
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
      Assert.Null(widget.Field("verb"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("kids"));
      Assert.Null(widget.Field("layout"));
      Assert.Null(widget.Field("trackLabel"));
      Assert.Null(widget.Field("faces"));
      Assert.Null(widget.Field("width"));
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
      Assert.Null(widget.Field("verb"));
      Assert.True(ReferenceEquals(widget.Verb("verb"), widget));
      Assert.Equal("verb", widget.Field("verb").To<string>());
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
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
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
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Kids(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Kids_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Field("kids"));
      Assert.True(ReferenceEquals(widget.Kids(), widget));
      Assert.True(widget.Field("kids").To<bool>());
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
      Assert.Null(widget.Field("layout"));
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Field("layout").To<string>());
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
      Assert.Null(widget.Field("trackLabel"));
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.Equal("trackLabel", widget.Field("trackLabel").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Faces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.Null(widget.Field("faces"));
      Assert.True(ReferenceEquals(widget.Faces(), widget));
      Assert.True(widget.Field("faces").To<bool>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new FacebookLikeButtonWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<div class=""fb-like"" data-href=""url""></div>", new StringWriter().With(writer => new FacebookLikeButtonWidget().Url("url").Write(writer)).ToString());
      Assert.Equal(@"<div class=""fb-like"" data-action=""recommend"" data-colorscheme=""dark"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-ref=""trackLabel"" data-show-faces=""true"" data-width=""width""></div>", new StringWriter().With(writer => new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).ColorScheme(FacebookColorScheme.Dark).Url("url").Kids().Layout(FacebookButtonLayout.BoxCount).TrackLabel("trackLabel").Faces().Width("width").Write(writer)).ToString());
    }
  }
}