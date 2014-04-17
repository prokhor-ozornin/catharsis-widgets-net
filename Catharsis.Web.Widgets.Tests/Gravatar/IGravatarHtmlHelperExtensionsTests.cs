using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IGravatarHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IGravatarHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarHtmlHelperExtensions.ImageUrl(IGravatarHtmlHelper, Action{IGravatarImageUrlWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void ImageUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarHtmlHelperExtensions.ImageUrl(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new GravatarHtmlHelper().ImageUrl(null));

      Assert.Equal(new GravatarHtmlHelper().ImageUrl().ToHtmlString(), new GravatarHtmlHelper().ImageUrl(x => { }));
      Assert.Equal(new GravatarHtmlHelper().ImageUrl().Hash("hash").ToHtmlString(), new GravatarHtmlHelper().ImageUrl(x => x.Hash("hash")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarHtmlHelperExtensions.ProfileUrl(IGravatarHtmlHelper, Action{IGravatarProfileUrlWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void ProfileUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarHtmlHelperExtensions.ProfileUrl(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new GravatarHtmlHelper().ProfileUrl(null));

      Assert.Equal(new GravatarHtmlHelper().ProfileUrl().ToHtmlString(), new GravatarHtmlHelper().ProfileUrl(x => { }));
      Assert.Equal(new GravatarHtmlHelper().ProfileUrl().Hash("hash").ToHtmlString(), new GravatarHtmlHelper().ProfileUrl(x => x.Hash("hash")));
    }
  }
}