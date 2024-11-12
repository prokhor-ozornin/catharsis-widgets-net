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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vkontakte(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vkontakte_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vkontakte(null));

      Assert.NotNull(html.Vkontakte());
      Assert.True(ReferenceEquals(html.Vkontakte(), html.Vkontakte()));
    }
  }
}