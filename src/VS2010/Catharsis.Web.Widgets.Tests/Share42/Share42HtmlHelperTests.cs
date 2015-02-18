using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="Share42HtmlHelper"/>.</para>
  /// </summary>
  public sealed class Share42HtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="Share42HtmlHelper.Panel()"/> method.</para>
    /// </summary>
    [Fact]
    public void Panel_Method()
    {
      Assert.False(ReferenceEquals(this.html.Share42().Panel(), this.html.Share42().Panel()));
      Assert.True(this.html.Share42().Panel() is Share42PanelWidget);
    }
  }
}