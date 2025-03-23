namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudWidgetsCreator"/>
public class SoundCloudWidgetsCreator : ISoundCloudWidgetsCreator
{
  /// <inheritdoc cref="ISoundCloudWidgetsCreator.ProfileIcon()"/>
  public virtual ISoundCloudProfileIconWidget ProfileIcon() => new SoundCloudProfileIconWidget();
}