using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Twitter(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Twitter_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Twitter(null));

    Assert.NotNull(html.Twitter());
    Assert.True(ReferenceEquals(html.Twitter(), html.Twitter()));
  }
}