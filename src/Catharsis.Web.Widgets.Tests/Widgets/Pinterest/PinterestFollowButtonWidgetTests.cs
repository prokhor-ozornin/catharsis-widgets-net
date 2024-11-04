using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestFollowButtonWidget"/>.</para>
  /// </summary>
  public sealed class PinterestFollowButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="PinterestFollowButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new PinterestFollowButtonWidget();
      Assert.Null(widget.Account());
      Assert.Equal("Follow", widget.Label());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestFollowButtonWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new PinterestFollowButtonWidget().Account(string.Empty));

      var widget = new PinterestFollowButtonWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Label(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Label_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestFollowButtonWidget().Label(null));
      Assert.Throws<ArgumentException>(() => new PinterestFollowButtonWidget().Label(string.Empty));

      var widget = new PinterestFollowButtonWidget();
      Assert.Equal("Follow", widget.Label());
      Assert.True(ReferenceEquals(widget.Label("label"), widget));
      Assert.Equal("label", widget.Label());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new PinterestFollowButtonWidget().ToString());
      Assert.Equal(@"<a data-pin-do=""buttonFollow"" href=""http://www.pinterest.com/account"">Follow</a>", new PinterestFollowButtonWidget().Account("account").ToString());
      Assert.Equal(@"<a data-pin-do=""buttonFollow"" href=""http://www.pinterest.com/account"">label</a>", new PinterestFollowButtonWidget().Account("account").Label("label").ToString());
    }
  }
}