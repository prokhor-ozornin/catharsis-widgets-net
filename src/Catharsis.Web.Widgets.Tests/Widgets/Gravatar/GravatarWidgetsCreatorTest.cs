using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarWidgetsCreator"/>.</para>
/// </summary>
public sealed class GravatarWidgetsCreatorTest : Test
{
  private IGravatarWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Gravatar();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(GravatarWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IGravatarWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ImageUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ImageLink_Method()
  {
    Widgets.ImageUrl().Should().BeOfType<GravatarImageUrlWidget>().And.NotBeSameAs(Widgets.ImageUrl());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ProfileUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileLink_Method()
  {
    Widgets.ProfileUrl().Should().BeOfType<GravatarProfileUrlWidget>().And.NotBeSameAs(Widgets.ProfileUrl());
  }
}