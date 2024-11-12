using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestHtmlHelper"/>.</para>
  /// </summary>
  public sealed class PinterestHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestHtmlHelper.Board()"/> method.</para>
    /// </summary>
    [Fact]
    public void Board_Method()
    {
      Assert.False(ReferenceEquals(this.html.Pinterest().Board(), this.html.Pinterest().Board()));
      Assert.True(this.html.Pinterest().Board() is PinterestBoardWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestHtmlHelper.FollowButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.Pinterest().FollowButton(), this.html.Pinterest().FollowButton()));
      Assert.True(this.html.Pinterest().FollowButton() is PinterestFollowButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestHtmlHelper.PinItButton()"/> method.</para>
    /// </summary>
    [Fact]
    public void PinItButton_Method()
    {
      Assert.False(ReferenceEquals(this.html.Pinterest().PinItButton(), this.html.Pinterest().PinItButton()));
      Assert.True(this.html.Pinterest().PinItButton() is PinterestPinItButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestHtmlHelper.Pin()"/> method.</para>
    /// </summary>
    [Fact]
    public void Pin_Method()
    {
      Assert.False(ReferenceEquals(this.html.Pinterest().Pin(), this.html.Pinterest().Pin()));
      Assert.True(this.html.Pinterest().Pin() is PinterestPinWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestHtmlHelper.Profile()"/> method.</para>
    /// </summary>
    [Fact]
    public void Profile_Method()
    {
      Assert.False(ReferenceEquals(this.html.Pinterest().Profile(), this.html.Pinterest().Profile()));
      Assert.True(this.html.Pinterest().Profile() is PinterestProfileWidget);
    }
  }
}