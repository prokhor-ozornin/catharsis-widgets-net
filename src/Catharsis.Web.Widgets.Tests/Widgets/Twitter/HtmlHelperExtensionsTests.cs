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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Twitter(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Twitter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Twitter(null));

      Assert.NotNull(html.Twitter());
      Assert.True(ReferenceEquals(html.Twitter(), html.Twitter()));
    }
  }
}