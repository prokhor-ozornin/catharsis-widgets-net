using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="RuTubeWidgetsCreator"/>
public sealed class RuTubeWidgetsCreatorTests : ClassTest<RuTubeWidgetsCreator>
{
  private readonly IRuTubeWidgetsCreator widgets = Widgets.Web.RuTube();

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<RuTubeVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}