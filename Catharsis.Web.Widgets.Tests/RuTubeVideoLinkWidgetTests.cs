using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="RuTubeVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class RuTubeVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="RuTubeVideoLinkWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new RuTubeVideoLinkWidget();
      Assert.False(widget.Field("embedded").To<bool>());
      Assert.Null(widget.Field("id"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoLinkWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new RuTubeVideoLinkWidget().Id(string.Empty));

      var widget = new RuTubeVideoLinkWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoLinkWidget.Embedded(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Embedded_Method()
    {
      var widget = new RuTubeVideoLinkWidget();
      Assert.False(widget.Field("embedded").To<bool>());
      Assert.True(ReferenceEquals(widget.Embedded(), widget));
      Assert.True(widget.Field("embedded").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new RuTubeVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<a href=""http://rutube.ru/video/id""></a>", new StringWriter().With(writer => new RuTubeVideoLinkWidget().Id("id").Write(writer)).ToString());
      Assert.Equal(@"<a href=""http://rutube.ru/embed/id""></a>", new StringWriter().With(writer => new RuTubeVideoLinkWidget().Id("id").Embedded().Write(writer)).ToString());
    }
  }
}