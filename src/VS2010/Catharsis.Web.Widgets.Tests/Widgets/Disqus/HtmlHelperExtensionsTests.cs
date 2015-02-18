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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Disqus(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Disqus_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Disqus(null));

      Assert.NotNull(html.Disqus());
      Assert.True(ReferenceEquals(html.Disqus(), html.Disqus()));
    }
  }
}