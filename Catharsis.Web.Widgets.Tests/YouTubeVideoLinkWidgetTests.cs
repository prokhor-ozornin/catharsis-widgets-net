using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YouTubeVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class YouTubeVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YouTubeVideoLinkWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YouTubeVideoLinkWidget();
      Assert.Null(widget.Field("id"));
      Assert.False(widget.Field("embedded").To<bool>());
      Assert.False(widget.Field("private").To<bool>());
      Assert.False(widget.Field("secure").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YouTubeVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YouTubeVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YouTubeVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<a href=""http://www.youtube.com/watch?v=id""></a>", new StringWriter().With(writer => new YouTubeVideoLinkWidget().Id("id").Write(writer)).ToString());
      Assert.Equal(@"<a href=""https://www.youtube-nocookie.com/embed/id""></a>", new StringWriter().With(writer => new YouTubeVideoLinkWidget().Id("id").Embedded().Private().Secure().Write(writer)).ToString());
    }
  }
}