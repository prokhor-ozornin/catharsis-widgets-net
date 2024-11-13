using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ISoundCloudHtmlHelperExtensions"/>.</para>
/// </summary>
public sealed class ISoundCloudHtmlHelperExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudHtmlHelperExtensions.ProfileIcon(ISoundCloudWidgetCreator, Action{ISoundCloudProfileIconWidget}"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ISoundCloudHtmlHelperExtensions.ProfileIcon(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new SoundCloudWidgetCreator().ProfileIcon(null));

    Assert.Equal(new SoundCloudWidgetCreator().ProfileIcon().ToHtml(), new SoundCloudWidgetCreator().ProfileIcon(x => { }));
    Assert.Equal(new SoundCloudWidgetCreator().ProfileIcon().Account("account").ToHtml(), new SoundCloudWidgetCreator().ProfileIcon(x => x.Account("account")));
  }
}