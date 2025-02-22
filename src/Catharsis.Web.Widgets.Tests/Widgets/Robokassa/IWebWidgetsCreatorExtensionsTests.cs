using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Robokassa(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Robokassa_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Robokassa(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Robokassa().Should().BeOfType<RobokassaWidgetsCreator>().And.BeSameAs(Widgets.Robokassa());
  }
}