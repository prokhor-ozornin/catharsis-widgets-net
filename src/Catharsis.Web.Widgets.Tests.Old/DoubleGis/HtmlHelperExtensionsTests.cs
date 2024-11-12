using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed partial class HtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.DoubleGis(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void DoubleGis_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.DoubleGis(null));

      Assert.NotNull(html.DoubleGis());
      Assert.True(ReferenceEquals(html.DoubleGis(), html.DoubleGis()));
    }
  }
}