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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Google(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Google_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Google(null));

      Assert.NotNull(html.Google());
      Assert.True(ReferenceEquals(html.Google(), html.Google()));
    }
  }
}