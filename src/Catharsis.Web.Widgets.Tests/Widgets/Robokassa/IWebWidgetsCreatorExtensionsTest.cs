using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreatorExtensions"/>
public sealed partial class IWebWidgetsCreatorExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Robokassa(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Robokassa_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Robokassa(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.Robokassa().Should().BeOfType<RobokassaWidgetsCreator>().And.BeSameAs(Widgets.Create.Robokassa());
  }
}