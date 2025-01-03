using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YouTubeWidgetsCreator"/>.</para>
/// </summary>
public sealed class YouTubeWidgetsCreatorTests : ClassTest<YouTubeWidgetsCreator>
{
  private readonly IYouTubeWidgetsCreator widgets = Widgets.Create.YouTube();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YouTubeWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YouTubeWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IYouTubeWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<YouTubeVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}