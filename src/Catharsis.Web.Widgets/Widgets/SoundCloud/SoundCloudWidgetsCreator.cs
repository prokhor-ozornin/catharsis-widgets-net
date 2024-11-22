namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudWidgetsCreator"/>
public class SoundCloudWidgetsCreator : ISoundCloudWidgetsCreator
{
  /// <inheritdoc cref="ISoundCloudWidgetsCreator.ProfileIcon()"/>
  public ISoundCloudProfileIconWidget ProfileIcon() => new SoundCloudProfileIconWidget();
}