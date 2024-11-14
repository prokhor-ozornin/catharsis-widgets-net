using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Surfingbird(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Surfingbird_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Surfingbird(null));

    Assert.NotNull(html.Surfingbird());
    Assert.True(ReferenceEquals(html.Surfingbird(), html.Surfingbird()));
  }
}