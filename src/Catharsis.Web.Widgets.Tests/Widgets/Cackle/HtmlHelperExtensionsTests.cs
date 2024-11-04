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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Cackle(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cackle_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Cackle(null));

      Assert.NotNull(html.Cackle());
      Assert.True(ReferenceEquals(html.Cackle(), html.Cackle()));
    }
  }
}