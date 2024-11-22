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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Robokassa(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Robokassa_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Robokassa(null));

    widgets.Robokassa().Should().BeOfType<RobokassaWidgetsCreator>().And.BeSameAs(widgets.Robokassa());
  }
}