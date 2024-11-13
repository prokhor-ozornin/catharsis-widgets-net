using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IVimeoWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class VimeoWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVimeoWidgetCreatorExtensions.Video(IVimeoWidgetCreator, Action{IVimeoVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVimeoWidgetCreatorExtensions.Video(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new VimeoWidgetCreator().Video(null));

    Assert.Equal(new VimeoWidgetCreator().Video().ToHtml(), new VimeoWidgetCreator().Video(x => { }));
    Assert.Equal(new VimeoWidgetCreator().Video().Id("id").ToHtml(), new VimeoWidgetCreator().Video(x => x.Id("id")));
  }
}