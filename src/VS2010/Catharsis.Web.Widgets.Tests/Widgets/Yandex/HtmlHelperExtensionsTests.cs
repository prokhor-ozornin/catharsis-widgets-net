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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Yandex(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Yandex_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Yandex(null));

      Assert.NotNull(html.Yandex());
      Assert.True(ReferenceEquals(html.Yandex(), html.Yandex()));
    }
  }
}