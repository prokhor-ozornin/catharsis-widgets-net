using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IRuTubeWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class IRuTubeWidgetCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IRuTubeWidgetCreatorExtensions.Video(IRuTubeWidgetCreator, Action{IRuTubeVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IRuTubeWidgetCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new RuTubeWidgetCreator().Video(null));

    Assert.Equal(new RuTubeWidgetCreator().Video().ToHtml(), new RuTubeWidgetCreator().Video(_ => { }));
    Assert.Equal(new RuTubeWidgetCreator().Video().Id("id").ToHtml(), new RuTubeWidgetCreator().Video(x => x.Id("id")));
  }
}