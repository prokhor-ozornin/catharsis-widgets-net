using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IRuTubeWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IRuTubeWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IRuTubeWidgetsCreatorExtensions.Video(IRuTubeWidgetsCreator, Action{IRuTubeVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IRuTubeWidgetsCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new RuTubeWidgetsCreator().Video(null));

    Assert.Equal(new RuTubeWidgetsCreator().Video().ToHtml(), new RuTubeWidgetsCreator().Video(_ => { }));
    Assert.Equal(new RuTubeWidgetsCreator().Video().Id("id").ToHtml(), new RuTubeWidgetsCreator().Video(x => x.Id("id")));
  }
}