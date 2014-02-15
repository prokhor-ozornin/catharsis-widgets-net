using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookVideoWidget"/>.</para>
  /// </summary>
  public sealed class FacebookVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="FacebookVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Id(string.Empty));

      var widget = new FacebookVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Width(string.Empty));

      var widget = new FacebookVideoWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Height(string.Empty));

      var widget = new FacebookVideoWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Write(null));

      Assert.True(new StringWriter().With(new FacebookVideoWidget().Write).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookVideoWidget().Id("id").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookVideoWidget().Id("id").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookVideoWidget().Id("width").Height("height").Write(writer)).ToString().IsEmpty());

      Assert.True(new StringWriter().With(writer => new FacebookVideoWidget().Id("id").Width("width").Height("height").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://www.facebook.com/video/embed?video_id=id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}