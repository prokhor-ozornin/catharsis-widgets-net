using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SoundCloudWidgetsCreator"/>.</para>
/// </summary>
public sealed class SoundCloudWidgetsCreatorTests : ClassTest<SoundCloudWidgetsCreator>
{
  private readonly ISoundCloudWidgetsCreator widgets = Widgets.Web.SoundCloud();

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudWidgetsCreator.ProfileIcon()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    Assert.False(ReferenceEquals(widgets.ProfileIcon(), widgets.ProfileIcon()));
    Assert.True(widgets.ProfileIcon() is SoundCloudProfileIconWidget);
  }
}