using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlWidgetBase{T}"/>.</para>
  /// </summary>
  public sealed class HtmlWidgetBaseTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase{T}.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.Equal(MockHtmlWidget.Contents, widget.ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase{T}.ToString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToString_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.Equal(MockHtmlWidget.Contents, widget.ToString());
      Assert.Equal(widget.ToHtmlString(), widget.ToString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase{T}.HtmlAttributes"/> property.</para>
    /// </summary>
    [Fact]
    public void HtmlAttributes_Property()
    {
      var widget = new MockHtmlWidget();
      Assert.False(widget.HtmlAttributes.Any());
      widget.HtmlAttributes["key"] = string.Empty;
      Assert.Equal(string.Empty, widget.HtmlAttributes["key"].To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase{T}.HtmlBody"/> property.</para>
    /// </summary>
    [Fact]
    public void HtmlBody_Property()
    {
      var widget = new MockHtmlWidget();
      Assert.Null(widget.HtmlBody);
      widget.HtmlBody = "html";
      Assert.Equal("html", widget.HtmlBody);
    }
  }
}