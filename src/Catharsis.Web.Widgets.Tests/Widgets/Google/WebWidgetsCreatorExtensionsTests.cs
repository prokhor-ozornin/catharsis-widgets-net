using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Google(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Google_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Google(null));

    Assert.NotNull(html.Google());
    Assert.True(ReferenceEquals(html.Google(), html.Google()));
  }
}