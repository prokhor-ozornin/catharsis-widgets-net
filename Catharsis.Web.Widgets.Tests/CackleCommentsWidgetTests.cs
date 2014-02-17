using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CackleCommentsWidget"/>.</para>
  /// </summary>
  public sealed class CackleCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="CackleCommentsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleCommentsWidget();
      Assert.Null(widget.Field("account"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleCommentsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new CackleCommentsWidget().Account(string.Empty));

      var widget = new CackleCommentsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    { 
      Assert.Throws<ArgumentNullException>(() => new CackleCommentsWidget().Write(null));

      Assert.True(new StringWriter().With(new CackleCommentsWidget().Write).ToString().IsEmpty());
      new StringWriter().With(writer =>
      {
        new CackleCommentsWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""mc-container""></div>"));
        Assert.True(html.Contains(@"{""widget"":""Comment"",""id"":""account""}"));
      });
    }
  }
}