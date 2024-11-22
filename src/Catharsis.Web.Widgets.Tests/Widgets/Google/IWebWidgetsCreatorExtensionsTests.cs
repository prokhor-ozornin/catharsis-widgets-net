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
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Google(null));

    widgets.Google().Should().BeOfType<GoogleWidgetsCreator>().And.BeSameAs(widgets.Google());
  }
}