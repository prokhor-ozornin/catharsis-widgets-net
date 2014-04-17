using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SoundCloudHtmlHelper"/>.</para>
  /// </summary>
  public sealed class SoundCloudHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="SoundCloudHtmlHelper.ProfileIcon()"/> method.</para>
    /// </summary>
    [Fact]
    public void ProfileIcon_Method()
    {
      Assert.False(ReferenceEquals(this.html.SoundCloud().ProfileIcon(), this.html.SoundCloud().ProfileIcon()));
      Assert.True(this.html.SoundCloud().ProfileIcon() is SoundCloudProfileIconWidget);
    }
  }
}