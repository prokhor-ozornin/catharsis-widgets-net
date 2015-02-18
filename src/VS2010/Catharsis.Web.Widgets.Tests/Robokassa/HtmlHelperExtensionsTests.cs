using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="Widgets.HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed partial class HtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Robokassa(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Robokassa_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Robokassa(null));

      Assert.NotNull(html.Pinterest());
      Assert.True(ReferenceEquals(html.Pinterest(), html.Pinterest()));
    }
  }
}