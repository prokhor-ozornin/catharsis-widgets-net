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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Gravatar(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Gravatar_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Gravatar(null));

      Assert.NotNull(html.Gravatar());
      Assert.True(ReferenceEquals(html.Gravatar(), html.Gravatar()));
    }
  }
}