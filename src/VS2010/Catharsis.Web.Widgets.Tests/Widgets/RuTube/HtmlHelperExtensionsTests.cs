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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.RuTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void RuTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.RuTube(null));

      Assert.NotNull(html.RuTube());
      Assert.True(ReferenceEquals(html.RuTube(), html.RuTube()));
    }
  }
}