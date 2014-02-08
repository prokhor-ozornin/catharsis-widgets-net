using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CackleLoginWidget"/>.</para>
  /// </summary>
  public sealed class CackleLoginWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="CackleLoginWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleLoginWidget();
      Assert.True(widget.Field("account").To<string>() == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLoginWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleLoginWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new CackleLoginWidget().Account(string.Empty));

      var widget = new CackleLoginWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLoginWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void WriteTo_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleLoginWidget().Write(null));

      Assert.True(new StringWriter().With(new CackleLoginWidget().Write).ToString().IsEmpty());
      
      new StringWriter().With(writer =>
      {
        new CackleLoginWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""mc-login""></div>"));
        Assert.True(html.Contains(@"{""widget"":""Login"",""id"":""account""}"));
      });
    }
  }
}