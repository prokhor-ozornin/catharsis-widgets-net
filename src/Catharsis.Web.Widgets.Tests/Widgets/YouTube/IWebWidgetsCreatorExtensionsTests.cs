using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.YouTube(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void YouTube_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.YouTube(null));

    Assert.NotNull(html.YouTube());
    Assert.True(ReferenceEquals(html.YouTube(), html.YouTube()));
  }
}