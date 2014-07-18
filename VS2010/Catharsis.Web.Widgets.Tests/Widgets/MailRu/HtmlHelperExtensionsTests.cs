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
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.MailRu(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void MailRu_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.MailRu(null));

      Assert.NotNull(html.MailRu());
      Assert.True(ReferenceEquals(html.MailRu(), html.MailRu()));
    }
  }
}