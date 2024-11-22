using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVimeoWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IVimeoWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVimeoWidgetsCreatorExtensions.Video(IVimeoWidgetsCreator, Action{IVimeoVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVimeoWidgetsCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VimeoWidgetsCreator().Video(null));

    Assert.Equal(new VimeoWidgetsCreator().Video().ToHtml(), new VimeoWidgetsCreator().Video(_ => { }));
    Assert.Equal(new VimeoWidgetsCreator().Video().Id("id").ToHtml(), new VimeoWidgetsCreator().Video(x => x.Id("id")));
  }
}