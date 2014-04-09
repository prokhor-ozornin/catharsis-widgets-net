using System;
using System.IO;
using Catharsis.Commons;
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
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("posts"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("mobile"));
      Assert.Null(widget.Field("order"));
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
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Posts(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Posts_Method()
    {
      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Field("posts"));
      Assert.True(ReferenceEquals(widget.Posts(1), widget));
      Assert.Equal(1, widget.Field("posts").To<byte>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
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
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Mobile(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mobile_Method()
    {
      var widget = new FacebookCommentsWidget();
      Assert.Null(widget.Field("mobile"));
      Assert.True(ReferenceEquals(widget.Mobile(), widget));
      Assert.True(widget.Field("mobile").To<bool>());
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
      Assert.Null(widget.Field("order"));
      Assert.True(ReferenceEquals(widget.Order("order"), widget));
      Assert.Equal("order", widget.Field("order").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Write(null));

      Assert.Equal(@"<div class=""fb-comments""></div>", new StringWriter().With(writer => new FacebookCommentsWidget().Write(writer)).ToString());
      Assert.Equal(@"<div class=""fb-comments"" data-colorscheme=""dark"" data-href=""url"" data-mobile=""true"" data-num-posts=""1"" data-order-by=""reverse_time"" data-width=""width""></div>", new StringWriter().With(writer => new FacebookCommentsWidget().Url("url").Posts(1).Width("width").ColorScheme(FacebookColorScheme.Dark).Mobile().Order(FacebookCommentsOrder.ReverseTime).Write(writer)).ToString());
    }
  }
}