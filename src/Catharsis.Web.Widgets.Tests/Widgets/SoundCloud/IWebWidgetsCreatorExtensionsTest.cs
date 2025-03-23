using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.SoundCloud(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void SoundCloud_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.SoundCloud(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.SoundCloud().Should().BeOfType<SoundCloudWidgetsCreator>().And.BeSameAs(Widgets.SoundCloud());
  }
}