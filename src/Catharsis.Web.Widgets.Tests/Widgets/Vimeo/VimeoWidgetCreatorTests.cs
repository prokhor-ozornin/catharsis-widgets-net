using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VimeoWidgetCreator"/>.</para>
/// </summary>
public sealed class VimeoWidgetCreatorTests : ClassTest<VimeoWidgetCreator>
{
  private readonly IVimeoWidgetCreator widgets = Widgets.Web.Vimeo();

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is VimeoVideoWidget);
  }
}