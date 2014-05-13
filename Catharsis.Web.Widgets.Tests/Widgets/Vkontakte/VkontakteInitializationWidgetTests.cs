using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteInitializationWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteInitializationWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteInitializationWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteInitializationWidget();
      Assert.Null(widget.ApiId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ApiId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ApiId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteInitializationWidget().ApiId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteInitializationWidget().ApiId(string.Empty));

      var widget = new VkontakteInitializationWidget();
      Assert.Null(widget.ApiId());
      Assert.True(ReferenceEquals(widget.ApiId("apiId"), widget));
      Assert.Equal("apiId", widget.ApiId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontakteInitializationWidget().ToString());

      var html = new VkontakteInitializationWidget().ApiId("id").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.init({apiId:id, onlyWidgets:true});"));
    }
  }
}