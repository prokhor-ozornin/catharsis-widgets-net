using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVideoJSWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IVideoJsWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSWidgetsCreatorExtensions.Player(IVideoJSWidgetsCreator, Action{IVideoJSPlayerWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVideoJSWidgetsCreatorExtensions.Player(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VideoJSWidgetsCreator().Player(null));

    Assert.Equal(new VideoJSWidgetsCreator().Player().ToHtml(), new VideoJSWidgetsCreator().Player(_ => { }));
    Assert.Equal(new VideoJSWidgetsCreator().Player().Videos(new MediaSource("url", "contentType")).Width("width").Height("height").ToHtml(), new VideoJSWidgetsCreator().Player(x => x.Videos(new MediaSource("url", "contentType")).Width("width").Height("height")));
  }
}