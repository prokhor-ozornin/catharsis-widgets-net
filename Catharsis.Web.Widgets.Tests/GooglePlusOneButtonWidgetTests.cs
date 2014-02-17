using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GooglePlusOneButtonWidget"/>.</para>
  /// </summary>
  public sealed class GooglePlusOneButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="GooglePlusOneButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("language"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("size"));
      Assert.Null(widget.Field("alignment"));
      Assert.Null(widget.Field("annotation"));
      Assert.Null(widget.Field("callback"));
      Assert.Null(widget.Field("recommendations"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Url(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Width(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Size(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("size"));
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Alignment(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Alignment_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Alignment(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Alignment(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("alignment"));
      Assert.True(ReferenceEquals(widget.Alignment("alignment"), widget));
      Assert.Equal("alignment", widget.Field("alignment").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Annotation(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Annotation_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Annotation(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Annotation(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("annotation"));
      Assert.True(ReferenceEquals(widget.Annotation("annotation"), widget));
      Assert.Equal("annotation", widget.Field("annotation").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Callback(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Callback_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Callback(null));
      Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Callback(string.Empty));

      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("callback"));
      Assert.True(ReferenceEquals(widget.Callback("callback"), widget));
      Assert.Equal("callback", widget.Field("callback").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Recommendations(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Recommendations_Method()
    {
      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Field("recommendations"));
      Assert.True(ReferenceEquals(widget.Recommendations(), widget));
      Assert.True(widget.Field("recommendations").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Write(null));

      Assert.Equal("<g:plusone></g:plusone>", new StringWriter().With(writer => new GooglePlusOneButtonWidget().Write(writer)).ToString());
      Assert.Equal(@"<g:plusone align=""left"" annotation=""none"" data-callback=""callback"" data-recommendations=""true"" href=""url"" size=""small"" width=""width""></g:plusone>", new StringWriter().With(writer => new GooglePlusOneButtonWidget().Url("url").Size(GooglePlusOneButtonSize.Small).Annotation(GooglePlusOneButtonAnnotation.None).Width("width").Alignment(GooglePlusOneButtonAlignment.Left).Callback("callback").Recommendations().Write(writer)).ToString());
    }
  }
}