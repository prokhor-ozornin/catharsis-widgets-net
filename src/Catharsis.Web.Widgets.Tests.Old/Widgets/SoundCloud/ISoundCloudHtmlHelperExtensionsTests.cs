using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ISoundCloudHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ISoundCloudHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ISoundCloudHtmlHelperExtensions.ProfileIcon(ISoundCloudHtmlHelper, Action{ISoundCloudProfileIconWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void ProfileIcon_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISoundCloudHtmlHelperExtensions.ProfileIcon(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new SoundCloudHtmlHelper().ProfileIcon(null));

      Assert.Equal(new SoundCloudHtmlHelper().ProfileIcon().ToHtmlString(), new SoundCloudHtmlHelper().ProfileIcon(x => { }));
      Assert.Equal(new SoundCloudHtmlHelper().ProfileIcon().Account("account").ToHtmlString(), new SoundCloudHtmlHelper().ProfileIcon(x => x.Account("account")));
    }
  }
}