using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GoogleHtmlHelper"/>.</para>
  /// </summary>
  public sealed class GoogleHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleHtmlHelper.Analytics()"/> method.</para>
    /// </summary>
    [Fact]
    public void Analytics_Method()
    {
      Assert.False(ReferenceEquals(this.html.Google().Analytics(), this.html.Google().Analytics()));
      Assert.True(this.html.Google().Analytics() is GoogleAnalyticsWidget);
    }

    /*/// <summary>
    ///   <para>Performs testing of <see cref="GoogleHtmlHelper.Map()"/> method.</para>
    /// </summary>
    [Fact]
    public void Map_Method()
    {
      Assert.False(ReferenceEquals(this.html.Google().Map(), this.html.Google().Map()));
      Assert.True(this.html.Google().Map() is GoogleMapWidget);
    }*/

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleHtmlHelper.PlusOne()"/> method.</para>
    /// </summary>
    [Fact]
    public void PlusOne_Method()
    {
      Assert.False(ReferenceEquals(this.html.Google().PlusOne(), this.html.Google().PlusOne()));
      Assert.True(this.html.Google().PlusOne() is GooglePlusOneButtonWidget);
    }
  }
}