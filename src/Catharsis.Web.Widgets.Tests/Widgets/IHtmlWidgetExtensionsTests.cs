using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IHtmlWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IHtmlWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IHtmlWidgetExtensions.Render{T}(T)"/> method.</para>
    /// </summary>
    [Fact]
    public void Render_Method()
    {
      var widget = new MockHtmlWidget();
      Assert.True(ReferenceEquals(widget.Render(), widget));
    }
  }
}