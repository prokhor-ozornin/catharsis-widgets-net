using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteInitWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteInitWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteInitWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteInitWidget();
      Assert.Null(widget.Field("apiId"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteInitWidget.ApiId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ApiId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteInitWidget().ApiId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteInitWidget().ApiId(string.Empty));

      var widget = new VkontakteInitWidget();
      Assert.Null(widget.Field("apiId"));
      Assert.True(ReferenceEquals(widget.ApiId("apiId"), widget));
      Assert.Equal("apiId", widget.Field("apiId").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteInitWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontakteInitWidget().ToString());

      var html = new VkontakteInitWidget().ApiId("id").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.init({apiId:id, onlyWidgets:true});"));
    }
  }
}