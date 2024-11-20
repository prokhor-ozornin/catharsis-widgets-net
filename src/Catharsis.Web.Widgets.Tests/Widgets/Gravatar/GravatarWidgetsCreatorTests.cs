using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="GravatarWidgetsCreator"/>.</para>
/// </summary>
public sealed class GravatarWidgetsCreatorTests : ClassTest<GravatarWidgetsCreator>
{
  private readonly IGravatarWidgetsCreator widgets = Widgets.Web.Gravatar();

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ImageUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ImageLink_Method()
  {
    Assert.False(ReferenceEquals(widgets.ImageUrl(), widgets.ImageUrl()));
    Assert.True(widgets.ImageUrl() is GravatarImageUrlWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarWidgetsCreator.ProfileUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileLink_Method()
  {
    Assert.False(ReferenceEquals(widgets.ProfileUrl(), widgets.ProfileUrl()));
    Assert.True(widgets.ProfileUrl() is GravatarProfileUrlWidget);
  }
}