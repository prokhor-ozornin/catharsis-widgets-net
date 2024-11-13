using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Vimeo(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vimeo_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Vimeo(null));

    Assert.NotNull(html.Vimeo());
    Assert.True(ReferenceEquals(html.Vimeo(), html.Vimeo()));
  }
}