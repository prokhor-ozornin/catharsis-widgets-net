using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.RuTube(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void RuTube_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.RuTube(null));

    Assert.NotNull(html.RuTube());
    Assert.True(ReferenceEquals(html.RuTube(), html.RuTube()));
  }
}