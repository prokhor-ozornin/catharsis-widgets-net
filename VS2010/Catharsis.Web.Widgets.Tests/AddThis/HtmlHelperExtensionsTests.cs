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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.AddThis(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void AddThis_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.AddThis(null));

      Assert.NotNull(html.AddThis());
      Assert.True(ReferenceEquals(html.AddThis(), html.AddThis()));
    }
  }
}