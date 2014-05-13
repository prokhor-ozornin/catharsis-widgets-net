using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CackleCommentsCountWidget"/>.</para>
  /// </summary>
  public sealed class CackleCommentsCountWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="CackleCommentsCountWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleCommentsCountWidget();
      Assert.Null(widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleCommentsCountWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new CackleCommentsCountWidget().Account(string.Empty));

      var widget = new CackleCommentsCountWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new CackleCommentsCountWidget().ToString());
      Assert.True(new CackleCommentsCountWidget().Account("account").ToString().Contains(@"{""widget"":""CommentCount"",""id"":""account""}"));
    }
  }
}