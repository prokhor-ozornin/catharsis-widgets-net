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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Surfingbird(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Surfingbird_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Surfingbird(null));

      Assert.NotNull(html.Surfingbird());
      Assert.True(ReferenceEquals(html.Surfingbird(), html.Surfingbird()));
    }
  }
}