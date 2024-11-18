using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ISoundCloudWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class ISoundCloudWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudWidgetCreatorExtensions.ProfileIcon(ISoundCloudWidgetCreator, Action{ISoundCloudProfileIconWidget}"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ISoundCloudWidgetCreatorExtensions.ProfileIcon(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new SoundCloudWidgetCreator().ProfileIcon(null));

    Assert.Equal(new SoundCloudWidgetCreator().ProfileIcon().ToHtml(), new SoundCloudWidgetCreator().ProfileIcon(_ => { }));
    Assert.Equal(new SoundCloudWidgetCreator().ProfileIcon().Account("account").ToHtml(), new SoundCloudWidgetCreator().ProfileIcon(x => x.Account("account")));
  }
}