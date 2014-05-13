using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookPostWidget"/>.</para>
  /// </summary>
  public sealed class FacebookPostWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookPostWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookPostWidget();
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookPostWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookPostWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookPostWidget().Url(string.Empty));

      var widget = new FacebookPostWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookPostWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookPostWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookPostWidget().Width(string.Empty));

      var widget = new FacebookPostWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookPostWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookPostWidget().ToString());
      Assert.Equal(@"<div class=""fb-post"" data-href=""url"" data-width=""width""></div>", new FacebookPostWidget().Url("url").Width("width").ToString());
    }
  }
}