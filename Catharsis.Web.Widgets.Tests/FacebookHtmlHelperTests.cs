using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookHtmlHelper"/>.</para>
  /// </summary>
  public sealed class FacebookHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookHtmlHelper.Initialize()"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.False(ReferenceEquals(this.html.Facebook().Initialize(), this.html.Facebook().Initialize()));
      Assert.True(this.html.Facebook().Initialize() is FacebookInitWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookHtmlHelper.Like()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.Facebook().Like(), this.html.Facebook().Like()));
      Assert.True(this.html.Facebook().Like() is FacebookLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookHtmlHelper.Post()"/> method.</para>
    /// </summary>
    [Fact]
    public void Post_Method()
    {
      Assert.False(ReferenceEquals(this.html.Facebook().Post(), this.html.Facebook().Post()));
      Assert.True(this.html.Facebook().Post() is FacebookPostWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.Facebook().Video(), this.html.Facebook().Video()));
      Assert.True(this.html.Facebook().Video() is FacebookVideoWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookHtmlHelper.VideoLink()"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.False(ReferenceEquals(this.html.Facebook().VideoLink(), this.html.Facebook().VideoLink()));
      Assert.True(this.html.Facebook().VideoLink() is FacebookVideoLinkWidget);
    }
  }
}