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
    ///   <para>Performs testing of <see cref="SurfingbirdHtmlHelper.SurfButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void SurfButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.Surfingbird().SurfButton(), this.html.Surfingbird().SurfButton()));
      Assert.True(this.html.Surfingbird().SurfButton() is SurfingbirdSurfButtonWidget);
    }
  }
}