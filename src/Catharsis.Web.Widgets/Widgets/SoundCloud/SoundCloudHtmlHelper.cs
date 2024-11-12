namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudHtmlHelper"/>
public class SoundCloudHtmlHelper : ISoundCloudHtmlHelper
{
  /// <inheritdoc cref="ISoundCloudHtmlHelper.ProfileIcon()"/>
  public ISoundCloudProfileIconWidget ProfileIcon() => new SoundCloudProfileIconWidget();
}