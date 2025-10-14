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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.VideoJS(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void VideoJS_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.VideoJS(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.VideoJS().Should().BeOfType<VideoJSWidgetsCreator>().And.BeSameAs(Widgets.Create.VideoJS());
  }
}