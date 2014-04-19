using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlWidgetBase"/>.</para>
  /// </summary>
  public sealed class HtmlWidgetBaseTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.Equal(MockHtmlWidget.Contents, widget.ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidgetBase.ToString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToString_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.Equal(MockHtmlWidget.Contents, widget.ToString());
      Assert.Equal(widget.ToHtmlString(), widget.ToString());
    }
  }
}