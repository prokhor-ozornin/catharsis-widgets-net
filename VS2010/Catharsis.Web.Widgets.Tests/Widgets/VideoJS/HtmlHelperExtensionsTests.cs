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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.VideoJS(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoJS_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.VideoJS(null));

      Assert.NotNull(html.VideoJS());
      Assert.True(ReferenceEquals(html.VideoJS(), html.VideoJS()));
    }
  }
}