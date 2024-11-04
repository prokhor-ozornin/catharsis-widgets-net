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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.LiveJournal(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void LiveJournal_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.LiveJournal(null));

      Assert.NotNull(html.LiveJournal());
      Assert.True(ReferenceEquals(html.LiveJournal(), html.LiveJournal()));
    }
  }
}