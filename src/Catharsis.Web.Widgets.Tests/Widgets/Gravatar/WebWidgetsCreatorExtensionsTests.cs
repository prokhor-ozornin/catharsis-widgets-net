using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Gravatar(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gravatar_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Gravatar(null));

    Assert.NotNull(html.Gravatar());
    Assert.True(ReferenceEquals(html.Gravatar(), html.Gravatar()));
  }
}