using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="WebWidget"/>.</para>
/// </summary>
public sealed class WebWidgetTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="WebWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    var widget = new MockWebWidget();
    Assert.Equal(MockWebWidget.Contents, widget.ToHtml());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="WebWidget.ToString()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToString_Method()
  {
    var widget = new MockWebWidget();
    Assert.Equal(MockWebWidget.Contents, widget.ToString());
    Assert.Equal(widget.ToHtml(), widget.ToString());
  }
}