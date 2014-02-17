using System;
using System.IO;
using Catharsis.Commons;
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
    ///   <seealso cref="FacebookPostWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookPostWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("width"));
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
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookPostWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookPostWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new FacebookPostWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<div class=""fb-post"" data-href=""url"" data-width=""width""></div>", new StringWriter().With(writer => new FacebookPostWidget().Url("url").Width("width").Write(writer)).ToString());
    }
  }
}