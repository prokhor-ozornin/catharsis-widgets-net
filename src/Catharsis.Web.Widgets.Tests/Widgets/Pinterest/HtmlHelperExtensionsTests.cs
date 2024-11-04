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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Pinterest(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Pinterest_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Pinterest(null));

      Assert.NotNull(html.Pinterest());
      Assert.True(ReferenceEquals(html.Pinterest(), html.Pinterest()));
    }
  }
}