using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SurfingbirdHtmlHelper"/>.</para>
  /// </summary>
  public sealed class SurfingbirdHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdHtmlHelper.Surf()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.Surfingbird().Surf(), this.html.Surfingbird().Surf()));
      Assert.True(this.html.Surfingbird().Surf() is SurfingbirdSurfButtonWidget);
    }
  }
}