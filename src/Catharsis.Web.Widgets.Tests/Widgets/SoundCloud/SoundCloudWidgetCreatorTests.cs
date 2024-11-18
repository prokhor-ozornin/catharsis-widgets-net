using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="SoundCloudWidgetCreator"/>.</para>
/// </summary>
public sealed class SoundCloudWidgetCreatorTests
{
  private readonly ISoundCloudWidgetCreator widgets = Widgets.Web.SoundCloud();

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudWidgetCreator.ProfileIcon()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    Assert.False(ReferenceEquals(widgets.ProfileIcon(), widgets.ProfileIcon()));
    Assert.True(widgets.ProfileIcon() is SoundCloudProfileIconWidget);
  }
}