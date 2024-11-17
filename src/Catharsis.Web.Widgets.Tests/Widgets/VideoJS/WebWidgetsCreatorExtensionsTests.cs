using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.VideoJS(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void VideoJS_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.VideoJS(null));

    Assert.NotNull(html.VideoJS());
    Assert.True(ReferenceEquals(html.VideoJS(), html.VideoJS()));
  }
}