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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vimeo(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vimeo_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vimeo(null));

      Assert.NotNull(html.Vimeo());
      Assert.True(ReferenceEquals(html.Vimeo(), html.Vimeo()));
    }
  }
}