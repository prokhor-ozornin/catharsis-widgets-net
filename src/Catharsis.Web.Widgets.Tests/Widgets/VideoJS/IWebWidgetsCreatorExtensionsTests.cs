using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.VideoJS(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void VideoJS_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.VideoJS(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.VideoJS().Should().BeOfType<VideoJSWidgetsCreator>().And.BeSameAs(Widgets.VideoJS());
  }
}