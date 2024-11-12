using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlWidget"/>.</para>
  /// </summary>
  public sealed class HtmlWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.Equal(MockHtmlWidget.Contents, widget.ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlWidget.ToString()"/> method.</para>
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