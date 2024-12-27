using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Share42(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Share42_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Share42(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    widgets.Share42().Should().BeOfType<Share42WidgetsCreator>().And.BeSameAs(widgets.Share42());
  }
}