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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Tumblr(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Tumblr_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Tumblr(null));

      Assert.NotNull(html.Tumblr());
      Assert.True(ReferenceEquals(html.Tumblr(), html.Tumblr()));
    }
  }
}