using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.RuTube(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void RuTube_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.RuTube(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.RuTube().Should().BeOfType<RuTubeWidgetsCreator>().And.BeSameAs(Widgets.RuTube());
  }
}