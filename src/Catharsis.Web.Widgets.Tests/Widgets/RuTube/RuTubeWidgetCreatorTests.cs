using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="RuTubeWidgetCreator"/>
public sealed class RuTubeWidgetCreatorTests : ClassTest<RuTubeWidgetCreator>
{
  private readonly IRuTubeWidgetCreator widgets = Widgets.Web.RuTube();

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets, widgets));
    Assert.True(widgets is RuTubeVideoWidget);
  }
}