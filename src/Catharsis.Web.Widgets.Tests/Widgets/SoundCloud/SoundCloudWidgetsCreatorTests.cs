using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SoundCloudWidgetsCreator"/>.</para>
/// </summary>
public sealed class SoundCloudWidgetsCreatorTests : ClassTest<SoundCloudWidgetsCreator>
{
  private readonly ISoundCloudWidgetsCreator widgets = Widgets.Create.SoundCloud();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SoundCloudWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SoundCloudWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ISoundCloudWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudWidgetsCreator.ProfileIcon()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileIcon_Method()
  {
    widgets.ProfileIcon().Should().BeOfType<SoundCloudProfileIconWidget>().And.NotBeSameAs(widgets.ProfileIcon());
  }
}