using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISoundCloudWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class ISoundCloudWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudWidgetsCreatorExtensions.ProfileIcon(ISoundCloudWidgetsCreator, Action{ISoundCloudProfileIconWidget}"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ISoundCloudWidgetsCreatorExtensions.ProfileIcon(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new SoundCloudWidgetsCreator().ProfileIcon(null));

    Assert.Equal(new SoundCloudWidgetsCreator().ProfileIcon().ToHtml(), new SoundCloudWidgetsCreator().ProfileIcon(_ => { }));
    Assert.Equal(new SoundCloudWidgetsCreator().ProfileIcon().Account("account").ToHtml(), new SoundCloudWidgetsCreator().ProfileIcon(x => x.Account("account")));
  }
}