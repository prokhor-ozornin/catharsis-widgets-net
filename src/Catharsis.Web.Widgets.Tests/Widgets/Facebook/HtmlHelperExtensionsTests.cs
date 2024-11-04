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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Facebook(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Facebook_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Facebook(null));

      Assert.NotNull(html.Facebook());
      Assert.True(ReferenceEquals(html.Facebook(), html.Facebook()));
    }
  }
}