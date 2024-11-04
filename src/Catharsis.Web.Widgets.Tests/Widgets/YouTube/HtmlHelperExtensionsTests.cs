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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.YouTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void YouTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.YouTube(null));

      Assert.NotNull(html.YouTube());
      Assert.True(ReferenceEquals(html.YouTube(), html.YouTube()));
    }
  }
}