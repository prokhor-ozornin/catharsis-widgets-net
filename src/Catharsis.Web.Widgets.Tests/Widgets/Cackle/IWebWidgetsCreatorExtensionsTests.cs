using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Cackle(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cackle_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Cackle(null));

    widgets.Cackle().Should().BeOfType<CackleWidgetsCreator>().And.BeSameAs(widgets.Cackle());
  }
}