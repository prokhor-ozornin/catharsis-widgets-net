using System;
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
    /// </summary>
    /// <seealso cref="CackleLoginWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleLoginWidget();
      Assert.Null(widget.Field("account"));
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
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLoginWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new CackleLoginWidget().ToString());

      var html = new CackleLoginWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<div id=""mc-login""></div>"));
      Assert.True(html.Contains(@"{""widget"":""Login"",""id"":""account""}"));
    }
  }
}