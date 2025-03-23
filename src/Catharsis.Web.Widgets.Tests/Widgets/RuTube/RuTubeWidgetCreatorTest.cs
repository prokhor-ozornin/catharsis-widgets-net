using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="RuTubeWidgetsCreator"/>
public sealed class RuTubeWidgetsCreatorTest : UnitTest
{
  private IRuTubeWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.RuTube();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="RuTubeWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(RuTubeWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IRuTubeWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<RuTubeVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}