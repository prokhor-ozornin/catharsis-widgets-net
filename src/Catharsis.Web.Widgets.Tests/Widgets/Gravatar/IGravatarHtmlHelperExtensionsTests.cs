using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IGravatarWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class GravatarWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarWidgetsCreatorExtensions.ImageUrl(IGravatarWidgetsCreator, Action{IGravatarImageUrlWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImageUrl_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IGravatarWidgetsCreatorExtensions.ImageUrl(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new GravatarWidgetsCreator().ImageUrl(null));

    Assert.Equal(new GravatarWidgetsCreator().ImageUrl().ToHtml(), new GravatarWidgetsCreator().ImageUrl(_ => { }));
    Assert.Equal(new GravatarWidgetsCreator().ImageUrl().Hash("hash").ToHtml(), new GravatarWidgetsCreator().ImageUrl(x => x.Hash("hash")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarWidgetsCreatorExtensions.ProfileUrl(IGravatarWidgetsCreator, Action{IGravatarProfileUrlWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void ProfileUrl_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IGravatarWidgetsCreatorExtensions.ProfileUrl(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new GravatarWidgetsCreator().ProfileUrl(null));

    Assert.Equal(new GravatarWidgetsCreator().ProfileUrl().ToHtml(), new GravatarWidgetsCreator().ProfileUrl(_ => { }));
    Assert.Equal(new GravatarWidgetsCreator().ProfileUrl().Hash("hash").ToHtml(), new GravatarWidgetsCreator().ProfileUrl(x => x.Hash("hash")));
  }
}