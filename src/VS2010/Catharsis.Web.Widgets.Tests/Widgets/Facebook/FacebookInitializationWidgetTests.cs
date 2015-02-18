using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookInitializationWidget"/>.</para>
  /// </summary>
  public sealed class FacebookInitializationWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookInitializationWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookInitializationWidget();
      Assert.Null(widget.AppId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookInitializationWidget.AppId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void AppId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookInitializationWidget().AppId(null));
      Assert.Throws<ArgumentException>(() => new FacebookInitializationWidget().AppId(string.Empty));

      var widget = new FacebookInitializationWidget();
      Assert.Null(widget.AppId());
      Assert.True(ReferenceEquals(widget.AppId("appId"), widget));
      Assert.Equal("appId", widget.AppId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookInitializationWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookInitializationWidget().ToString());

      var html = new FacebookInitializationWidget().AppId("appId").ToString();
      Assert.True(html.Contains(@"<div id=""fb-root""></div>"));
      Assert.True(html.Contains(@"//connect.facebook.net/en_US/all.js#xfbml=1&appId=appId"));
    }
  }
}