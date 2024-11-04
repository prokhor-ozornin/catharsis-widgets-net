using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="DoubleGisHtmlHelper"/>.</para>
  /// </summary>
  public sealed class DoubleGisHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="DoubleGisHtmlHelper.ContactsMap()"/> method.</para>
    /// </summary>
    [Fact]
    public void ContactsMap_Method()
    {
      Assert.False(ReferenceEquals(this.html.DoubleGis().ContactsMap(), this.html.DoubleGis().ContactsMap()));
      Assert.True(this.html.DoubleGis().ContactsMap() is DoubleGisContactsMapWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="DoubleGisHtmlHelper.Map()"/> method.</para>
    /// </summary>
    [Fact]
    public void Map_Method()
    {
      Assert.False(ReferenceEquals(this.html.DoubleGis().Map(), this.html.DoubleGis().Map()));
      Assert.True(this.html.DoubleGis().Map() is DoubleGisMapWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="DoubleGisHtmlHelper.MiniMap()"/> method.</para>
    /// </summary>
    [Fact]
    public void MiniMap_Method()
    {
      Assert.False(ReferenceEquals(this.html.DoubleGis().MiniMap(), this.html.DoubleGis().MiniMap()));
      Assert.True(this.html.DoubleGis().MiniMap() is DoubleGisMiniMapWidget);
    }
  }
}