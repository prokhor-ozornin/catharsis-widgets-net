using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IHtmlWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IHtmlWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.HtmlAttributes{T}(T, object)"/> method.</para>
    /// </summary>
    [Fact]
    public void HtmlAttributes_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.HtmlAttributes<MockHtmlWidget>(null, new object()));
      Assert.Throws<ArgumentNullException>(() => new MockHtmlWidget().HtmlAttributes(null));

      var widget = new MockHtmlWidget();
      Assert.True(ReferenceEquals(widget.HtmlAttributes(new object()), widget));
      Assert.False(widget.HtmlAttributes(new object()).HtmlAttributes.Any());
      Assert.True(widget.HtmlAttributes(new { MyAttribute = "value" }).HtmlAttributes.Count == 1);
      Assert.True(widget.HtmlAttributes["MyAttribute"].To<string>() == "value");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.HtmlBody{T}(T, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void HtmlBody_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.HtmlBody<MockHtmlWidget>(null, string.Empty));

      var widget = new MockHtmlWidget();
      Assert.True(ReferenceEquals(widget.HtmlBody("html"), widget));
      Assert.True(widget.HtmlBody == "html");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.Write{T}(T, Stream, Encoding)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.Write<MockHtmlWidget>(null, Stream.Null));
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.Write(new MockHtmlWidget(), null));

      var widget = new MockHtmlWidget();
      new MemoryStream().With(stream =>
      {
        Assert.True(ReferenceEquals(widget.Write(stream), widget));
        Assert.True(stream.Rewind().Text() == MockHtmlWidget.Contents);
      });
      new MemoryStream().With(stream =>
      {
        widget.Write(stream, Encoding.Unicode);
        Assert.True(stream.Rewind().Text(encoding: Encoding.Unicode) == MockHtmlWidget.Contents);
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.WriteHttp{T}(T)"/> method.</para>
    /// </summary>
    [Fact]
    public void WriteHttp_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.True(ReferenceEquals(widget.WriteHttp(), widget));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.ToTag{T}(T, string, Action{TagBuilder})"/> method.</para>
    /// </summary>
    [Fact]
    public void ToTag_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.ToTag<MockHtmlWidget>(null, "tag"));
      Assert.Throws<ArgumentNullException>(() => new MockHtmlWidget().ToTag(null));
      Assert.Throws<ArgumentException>(() => new MockHtmlWidget().ToTag(string.Empty));

      new MockHtmlWidget().With(widget => Assert.True(widget.ToTag("tag") == "<tag></tag>"));
      new MockHtmlWidget().With(widget => Assert.True(widget.HtmlAttributes(new { first = "value1", second = "value2" }).ToTag("tag") == @"<tag first=""value1"" second=""value2""></tag>"));
      new MockHtmlWidget().With(widget => Assert.True(widget.HtmlAttributes(new { first = "value1", second = "value2" }).ToTag("tag", builder => builder.Attribute("third", "value3")) == @"<tag first=""value1"" second=""value2"" third=""value3""></tag>"));
    }

    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="IHtmlWidgetExtensions.JavaScript{T}(T, string)"/></description></item>
    ///     <item><description><see cref="IHtmlWidgetExtensions.JavaScript{T}(T, Uri)"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void JavaScript_Methods()
    {
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.JavaScript<MockHtmlWidget>(null, "code"));
      Assert.Throws<ArgumentNullException>(() => IHtmlWidgetExtensions.JavaScript<MockHtmlWidget>(null, "http://localhost".ToUri()));
      Assert.Throws<ArgumentNullException>(() => new MockHtmlWidget().JavaScript((string) null));
      Assert.Throws<ArgumentNullException>(() => new MockHtmlWidget().JavaScript((Uri) null));
      Assert.Throws<ArgumentException>(() => new MockHtmlWidget().JavaScript(string.Empty));

      Assert.True(new MockHtmlWidget().JavaScript("code") == @"<script type=""text/javascript"">code</script>");
      Assert.True(new MockHtmlWidget().JavaScript("http://localhost".ToUri()) == @"<script src=""http://localhost/"" type=""text/javascript""></script>");
    }
  }
}