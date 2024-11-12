using System;
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
    /// </summary>
    /// <seealso cref="GooglePlusOneButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
      Assert.Null(widget.Size());
      Assert.Null(widget.Alignment());
      Assert.Null(widget.Annotation());
      Assert.Null(widget.Callback());
      Assert.Null(widget.Recommendations());
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
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
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
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
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
      Assert.Null(widget.Size());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Size());
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
      Assert.Null(widget.Alignment());
      Assert.True(ReferenceEquals(widget.Alignment("alignment"), widget));
      Assert.Equal("alignment", widget.Alignment());
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
      Assert.Null(widget.Annotation());
      Assert.True(ReferenceEquals(widget.Annotation("annotation"), widget));
      Assert.Equal("annotation", widget.Annotation());
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
      Assert.Null(widget.Callback());
      Assert.True(ReferenceEquals(widget.Callback("callback"), widget));
      Assert.Equal("callback", widget.Callback());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Recommendations(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Recommendations_Method()
    {
      var widget = new GooglePlusOneButtonWidget();
      Assert.Null(widget.Recommendations());
      Assert.True(ReferenceEquals(widget.Recommendations(true), widget));
      Assert.True(widget.Recommendations().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal("<g:plusone></g:plusone>", new GooglePlusOneButtonWidget().ToString());
      Assert.Equal(@"<g:plusone align=""left"" annotation=""none"" data-callback=""callback"" data-recommendations=""true"" href=""url"" size=""small"" width=""width""></g:plusone>", new GooglePlusOneButtonWidget().Url("url").Size(GooglePlusOneButtonSize.Small).Annotation(GooglePlusOneButtonAnnotation.None).Width("width").Alignment(GooglePlusOneButtonAlignment.Left).Callback("callback").Recommendations(true).ToString());
    }
  }
}