namespace Catharsis.Web.Widgets
{
  internal sealed class SoundCloudHtmlHelper : ISoundCloudHtmlHelper
  {
    public ISoundCloudProfileIconWidget ProfileIcon()
    {
      return new SoundCloudProfileIconWidget();
    }
  }
}