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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.DoubleGis(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void DoubleGis_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.DoubleGis(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.DoubleGis().Should().BeOfType<DoubleGisWidgetsCreator>().And.BeSameAs(Widgets.DoubleGis());
  }
}