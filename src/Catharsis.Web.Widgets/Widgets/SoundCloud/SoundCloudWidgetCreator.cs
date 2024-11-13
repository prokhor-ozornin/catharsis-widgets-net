namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudWidgetCreator"/>
public class SoundCloudWidgetCreator : ISoundCloudWidgetCreator
{
  /// <inheritdoc cref="ISoundCloudWidgetCreator.ProfileIcon()"/>
  public ISoundCloudProfileIconWidget ProfileIcon() => new SoundCloudProfileIconWidget();
}