using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetExtensions"/>.</para>
/// </summary>
public sealed class WebWidgetExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetExtensions.Render{T}(T)"/> method.</para>
  /// </summary>
  [Fact]
  public void Render_Method()
  {
    var widget = new MockWebWidget();
    Assert.True(ReferenceEquals(widget.Render(), widget));
  }
}