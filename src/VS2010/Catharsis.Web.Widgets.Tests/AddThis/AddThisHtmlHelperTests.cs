using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="AddThisHtmlHelper"/>.</para>
  /// </summary>
  public sealed class AddThisHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="AddThisHtmlHelper.SmartLayers()"/> method.</para>
    /// </summary>
    [Fact]
    public void SmartLayers_Method()
    {
      Assert.False(ReferenceEquals(this.html.AddThis().SmartLayers(), this.html.AddThis().SmartLayers()));
      Assert.True(this.html.AddThis().SmartLayers() is AddThisSmartLayersWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="AddThisHtmlHelper.ShareButtons()"/> method.</para>
    /// </summary>
    [Fact]
    public void ShareButtons_Method()
    {
      Assert.False(ReferenceEquals(this.html.AddThis().ShareButtons(), this.html.AddThis().ShareButtons()));
      Assert.True(this.html.AddThis().ShareButtons() is AddThisShareButtonsWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="AddThisHtmlHelper.FollowButtons()"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButtons_Method()
    {
      Assert.False(ReferenceEquals(this.html.AddThis().FollowButtons(), this.html.AddThis().FollowButtons()));
      Assert.True(this.html.AddThis().FollowButtons() is AddThisFollowButtonsWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="AddThisHtmlHelper.WelcomeBar()"/> method.</para>
    /// </summary>
    [Fact]
    public void WelcomeBar_Method()
    {
      Assert.False(ReferenceEquals(this.html.AddThis().WelcomeBar(), this.html.AddThis().WelcomeBar()));
      Assert.True(this.html.AddThis().WelcomeBar() is AddThisWelcomeBarWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="AddThisHtmlHelper.TrendingContent()"/> method.</para>
    /// </summary>
    [Fact]
    public void TrendingContent_Method()
    {
      Assert.False(ReferenceEquals(this.html.AddThis().TrendingContent(), this.html.AddThis().TrendingContent()));
      Assert.True(this.html.AddThis().TrendingContent() is AddThisTrendingContentWidget);
    }
  }
}