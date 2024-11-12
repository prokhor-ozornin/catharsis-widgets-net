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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.PayPal(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayPal_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.PayPal(null));

      Assert.NotNull(html.PayPal());
      Assert.True(ReferenceEquals(html.PayPal(), html.PayPal()));
    }
  }
}