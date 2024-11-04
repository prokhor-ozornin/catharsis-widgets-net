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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.IntenseDebate(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void IntenseDebate_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.IntenseDebate(null));

      Assert.NotNull(html.IntenseDebate());
      Assert.True(ReferenceEquals(html.IntenseDebate(), html.IntenseDebate()));
    }
  }
}