using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookInitWidget"/>.</para>
  /// </summary>
  public sealed class FacebookInitWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookInitWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookInitWidget();
      Assert.Null(widget.Field("appId"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookInitWidget.AppId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void AppId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookInitWidget().AppId(null));
      Assert.Throws<ArgumentException>(() => new FacebookInitWidget().AppId(string.Empty));

      var widget = new FacebookInitWidget();
      Assert.Null(widget.Field("appId"));
      Assert.True(ReferenceEquals(widget.AppId("appId"), widget));
      Assert.Equal("appId", widget.Field("appId").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookInitWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new FacebookInitWidget().ToString());

      var html = new FacebookInitWidget().AppId("appId").ToString();
      Assert.True(html.Contains(@"<div id=""fb-root""></div>"));
      Assert.True(html.Contains(@"//connect.facebook.net/en_US/all.js#xfbml=1&appId=appId"));
    }
  }
}