using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarWidgetsCreator"/>.</para>
/// </summary>
public sealed class GravatarWidgetsCreatorTests : ClassTest<GravatarWidgetsCreator>
{
  private readonly IGravatarWidgetsCreator widgets = Widgets.Web.Gravatar();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IGravatarWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ImageUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ImageLink_Method()
  {
    widgets.ImageUrl().Should().BeOfType<GravatarImageUrlWidget>().And.NotBeSameAs(widgets.ImageUrl());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ProfileUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileLink_Method()
  {
    widgets.ProfileUrl().Should().BeOfType<GravatarProfileUrlWidget>().And.NotBeSameAs(widgets.ProfileUrl());
  }
}