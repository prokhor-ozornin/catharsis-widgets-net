using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="WebWidgetsScripts"/>.</para>
  /// </summary>
  public sealed class WebWidgetsScriptsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="WebWidgetsScripts.Render()"/> method.</para>
    /// </summary>
    [Fact]
    public void Render_Method()
    {
      Assert.NotNull(WebWidgetsScripts.Render());
      Assert.True(ReferenceEquals(WebWidgetsScripts.Render(), WebWidgetsScripts.Render()));
    }
  }
}