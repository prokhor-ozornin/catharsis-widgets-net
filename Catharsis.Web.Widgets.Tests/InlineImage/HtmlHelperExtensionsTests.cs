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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.InlineImage(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void InlineImage_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.InlineImage(null));

      Assert.NotNull(html.InlineImage());
      Assert.False(ReferenceEquals(html.InlineImage(), html.InlineImage()));
      Assert.Equal(html.InlineImage().ToString(), html.InlineImage().ToString());
    }
  }
}