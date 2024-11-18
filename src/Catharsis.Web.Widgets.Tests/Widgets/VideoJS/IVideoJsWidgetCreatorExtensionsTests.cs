using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IVideoJSWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class IVideoJsWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSWidgetCreatorExtensions.Player(IVideoJSWidgetCreator, Action{IVideoJSPlayerWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVideoJSWidgetCreatorExtensions.Player(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VideoJsWidgetCreator().Player(null));

    Assert.Equal(new VideoJsWidgetCreator().Player().ToHtml(), new VideoJsWidgetCreator().Player(_ => { }));
    Assert.Equal(new VideoJsWidgetCreator().Player().Videos(new MediaSource("url", "contentType")).Width("width").Height("height").ToHtml(), new VideoJsWidgetCreator().Player(x => x.Videos(new MediaSource("url", "contentType")).Width("width").Height("height")));
  }
}