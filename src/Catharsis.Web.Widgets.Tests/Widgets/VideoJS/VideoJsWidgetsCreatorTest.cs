using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VideoJSWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="VideoJSWidgetsCreator"/>
public sealed class VideoJsWidgetsCreatorTest : Test
{
  private IVideoJSWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.VideoJS();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VideoJSWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(VideoJSWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IVideoJSWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="VideoJSWidgetsCreator.Player()"/> method.</para>
  /// </summary>
  [Fact]
  public void Player_Method()
  {
    Widgets.Player().Should().BeOfType<VideoJSPlayerWidget>().And.NotBeSameAs(Widgets.Player());
  }
}