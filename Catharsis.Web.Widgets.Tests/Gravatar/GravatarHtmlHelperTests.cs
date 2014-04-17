using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GravatarHtmlHelper"/>.</para>
  /// </summary>
  public sealed class GravatarHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarHtmlHelper.ImageUrl()"/> method.</para>
    /// </summary>
    [Fact]
    public void ImageLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.Gravatar().ImageUrl(), this.html.Gravatar().ImageUrl()));
      Assert.True(this.html.Gravatar().ImageUrl() is GravatarImageUrlWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarHtmlHelper.ProfileUrl()"/> method.</para>
    /// </summary>
    [Fact]
    public void ProfileLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.Gravatar().ProfileUrl(), this.html.Gravatar().ProfileUrl()));
      Assert.True(this.html.Gravatar().ProfileUrl() is GravatarProfileUrlWidget);
    }
  }
}