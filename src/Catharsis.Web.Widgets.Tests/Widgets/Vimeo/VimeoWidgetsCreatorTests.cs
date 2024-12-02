using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VimeoWidgetsCreator"/>.</para>
/// </summary>
public sealed class VimeoWidgetsCreatorTests : ClassTest<VimeoWidgetsCreator>
{
  private readonly IVimeoWidgetsCreator widgets = Widgets.Web.Vimeo();

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is VimeoVideoWidget);
  }
}