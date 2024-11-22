using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="RuTubeWidgetsCreator"/>
public sealed class RuTubeWidgetsCreatorTests : ClassTest<RuTubeWidgetsCreator>
{
  private readonly IRuTubeWidgetsCreator widgetses = Widgets.Web.RuTube();

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgetses, widgetses));
    Assert.True(widgetses is RuTubeVideoWidget);
  }
}