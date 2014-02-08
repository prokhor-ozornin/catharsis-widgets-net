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
    ///   <seealso cref="FacebookLikeButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.True(widget.Field("verb") == null);
      Assert.True(widget.Field("colorScheme") == null);
      Assert.True(widget.Field("url") == null);
      Assert.True(widget.Field("forKids") == null);
      Assert.True(widget.Field("layout") == null);
      Assert.True(widget.Field("trackLabel") == null);
      Assert.True(widget.Field("showFaces") == null);
      Assert.True(widget.Field("width") == null);
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
      Assert.True(widget.Field("verb") == null);
      Assert.True(ReferenceEquals(widget.Verb("verb"), widget));
      Assert.True(widget.Field("verb").To<string>() == "verb");
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
      Assert.True(widget.Field("colorScheme") == null);
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.True(widget.Field("colorScheme").To<string>() == "colorScheme");
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
      Assert.True(widget.Field("url") == null);
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ForKids(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ForKids_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.True(widget.Field("forKids") == null);
      Assert.True(ReferenceEquals(widget.ForKids(), widget));
      Assert.True(widget.Field("forKids").To<bool>());
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
      Assert.True(widget.Field("layout") == null);
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
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
      Assert.True(widget.Field("trackLabel") == null);
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.True(widget.Field("trackLabel").To<string>() == "trackLabel");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ShowFaces(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowFaces_Method()
    {
      var widget = new FacebookLikeButtonWidget();
      Assert.True(widget.Field("showFaces") == null);
      Assert.True(ReferenceEquals(widget.ShowFaces(), widget));
      Assert.True(widget.Field("showFaces").To<bool>());
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
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new FacebookLikeButtonWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookLikeButtonWidget().Url("url").Write(writer)).ToString() == @"<div class=""fb-like"" data-href=""url""></div>");
      Assert.True(new StringWriter().With(writer => new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).ColorScheme(FacebookLikeButtonColorScheme.Dark).Url("url").ForKids().Layout(FacebookLikeButtonLayout.BoxCount).TrackLabel("trackLabel").ShowFaces().Width("width").Write(writer)).ToString() == @"<div class=""fb-like"" data-action=""recommend"" data-colorscheme=""dark"" data-href=""url"" data-kid-directed-site=""true"" data-layout=""box_count"" data-ref=""trackLabel"" data-show-faces=""true"" data-width=""width""></div>");
    }
  }
}