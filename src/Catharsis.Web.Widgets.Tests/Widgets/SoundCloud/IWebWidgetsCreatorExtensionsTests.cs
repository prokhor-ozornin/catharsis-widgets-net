using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.SoundCloud(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void SoundCloud_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.SoundCloud(null));

    Assert.NotNull(html.SoundCloud());
    Assert.True(ReferenceEquals(html.SoundCloud(), html.SoundCloud()));
  }
}