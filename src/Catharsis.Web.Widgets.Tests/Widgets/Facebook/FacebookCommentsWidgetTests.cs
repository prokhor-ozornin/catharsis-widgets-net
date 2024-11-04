using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookCommentsWidget"/>.</para>
  /// </summary>
  public sealed class FacebookCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookCommentsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Mobile());
      Assert.Null(widget.Order());
      Assert.Null(widget.Posts());
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().ColorScheme(string.Empty));

      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Mobile(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mobile_Method()
    {
      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Mobile());
      Assert.True(ReferenceEquals(widget.Mobile(true), widget));
      Assert.True(widget.Mobile().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Order(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Order_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Order(null));
      Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Order(string.Empty));

      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Order());
      Assert.True(ReferenceEquals(widget.Order("order"), widget));
      Assert.Equal("order", widget.Order());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Posts(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Posts_Method()
    {
      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Posts());
      Assert.True(ReferenceEquals(widget.Posts(1), widget));
      Assert.Equal(1, widget.Posts().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Url(string.Empty));

      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Width(string.Empty));

      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""fb-comments""></div>", new FacebookCommentsWidget().ToString());
      Assert.Equal(@"<div class=""fb-comments"" data-colorscheme=""dark"" data-href=""url"" data-mobile=""true"" data-num-posts=""1"" data-order-by=""reverse_time"" data-width=""width""></div>", new FacebookCommentsWidget().Url("url").Posts(1).Width("width").ColorScheme(FacebookColorScheme.Dark).Mobile(true).Order(FacebookCommentsOrder.ReverseTime).ToString());
    }
  }
}