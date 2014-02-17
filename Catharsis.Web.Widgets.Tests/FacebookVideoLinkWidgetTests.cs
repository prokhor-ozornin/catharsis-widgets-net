using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class FacebookVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="FacebookVideoLinkWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookVideoLinkWidget();
      Assert.Null(widget.Field("id"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoLinkWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new FacebookVideoLinkWidget().Id(string.Empty));

      var widget = new FacebookVideoLinkWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(new FacebookVideoLinkWidget().Write).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new FacebookVideoLinkWidget().Id("id").Write(writer)).ToString().Contains(@"<a href=""https://www.facebook.com/photo.php?v=id"""));
    }
  }
}