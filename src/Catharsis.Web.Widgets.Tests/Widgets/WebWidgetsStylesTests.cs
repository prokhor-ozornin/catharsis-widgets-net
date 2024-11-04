using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="WebWidgetsStyles"/>.</para>
  /// </summary>
  public sealed class WebWidgetsStylesTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="WebWidgetsStyles.Render()"/> method.</para>
    /// </summary>
    [Fact]
    public void Render_Method()
    {
      Assert.NotNull(WebWidgetsStyles.Render());
      Assert.True(ReferenceEquals(WebWidgetsStyles.Render(), WebWidgetsStyles.Render()));
    }
  }
}