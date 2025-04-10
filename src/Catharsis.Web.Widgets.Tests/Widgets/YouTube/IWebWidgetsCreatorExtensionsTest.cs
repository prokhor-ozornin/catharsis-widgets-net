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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.YouTube(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void YouTube_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.YouTube(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.YouTube().Should().BeOfType<YouTubeWidgetsCreator>().And.BeSameAs(Widgets.Create.YouTube());
  }
}