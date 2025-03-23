using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Cackle(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cackle_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Cackle(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Cackle().Should().BeOfType<CackleWidgetsCreator>().And.BeSameAs(Widgets.Cackle());
  }
}