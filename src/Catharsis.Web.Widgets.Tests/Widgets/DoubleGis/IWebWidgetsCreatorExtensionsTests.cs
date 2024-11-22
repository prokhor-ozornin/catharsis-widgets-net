using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.DoubleGis(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void DoubleGis_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.DoubleGis(null));

    widgets.DoubleGis().Should().BeOfType<DoubleGisWidgetsCreator>().And.BeSameAs(widgets.DoubleGis());
  }
}