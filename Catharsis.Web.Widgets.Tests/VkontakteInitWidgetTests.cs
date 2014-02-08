using System;
using System.IO;
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
    ///   <seealso cref="VkontakteInitWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteInitWidget();
      Assert.True(widget.Field("apiId") == null);
    }

    [Fact]
    public void ApiId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteInitWidget().ApiId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteInitWidget().ApiId(string.Empty));

      var widget = new VkontakteInitWidget();
      Assert.True(widget.Field("apiId") == null);
      Assert.True(ReferenceEquals(widget.ApiId("apiId"), widget));
      Assert.True(widget.Field("apiId").To<string>() == "apiId");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteInitWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteInitWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VkontakteInitWidget().Write(writer)).ToString().IsEmpty());
      new StringWriter().With(writer =>
      {
        new VkontakteInitWidget().ApiId("id").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.init({apiId:id, onlyWidgets:true});"));
        Assert.True(html.Contains(@"<script src=""http://vk.com/js/api/openapi.jsopenapi.js"" type=""text/javascript""></script>"));
      });
    }
  }
}