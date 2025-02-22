using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Google(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Google_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Google(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Google().Should().BeOfType<GoogleWidgetsCreator>().And.BeSameAs(Widgets.Google());
  }
}