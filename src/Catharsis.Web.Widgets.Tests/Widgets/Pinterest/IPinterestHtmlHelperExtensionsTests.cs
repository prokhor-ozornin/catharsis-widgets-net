using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IPinterestHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IPinterestHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestHtmlHelperExtensions.Board(IPinterestHtmlHelper, Action{IPinterestBoardWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void Board_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestHtmlHelperExtensions.Board(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new PinterestHtmlHelper().Board(null));

      Assert.Equal(new PinterestHtmlHelper().Board().ToHtmlString(), new CackleHtmlHelper().Comments(x => { }));
      Assert.Equal(new PinterestHtmlHelper().Board().Account("account").Id("id").ToHtmlString(), new PinterestHtmlHelper().Board(x => x.Account("account").Id("id")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestHtmlHelperExtensions.FollowButton(IPinterestHtmlHelper, Action{IPinterestFollowButtonWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void FollowButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestHtmlHelperExtensions.FollowButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new PinterestHtmlHelper().FollowButton(null));

      Assert.Equal(new PinterestHtmlHelper().FollowButton().ToHtmlString(), new PinterestHtmlHelper().FollowButton(x => { }));
      Assert.Equal(new PinterestHtmlHelper().FollowButton().Account("account").ToHtmlString(), new PinterestHtmlHelper().FollowButton(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestHtmlHelperExtensions.PinItButton(IPinterestHtmlHelper, Action{IPinterestPinItButtonWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void PinItButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestHtmlHelperExtensions.PinItButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new PinterestHtmlHelper().PinItButton(null));

      Assert.Equal(new PinterestHtmlHelper().PinItButton().ToHtmlString(), new PinterestHtmlHelper().PinItButton(x => { }));
      Assert.Equal(new PinterestHtmlHelper().PinItButton().Url("url").Image("image").Description("description").ToHtmlString(), new PinterestHtmlHelper().PinItButton(x => x.Url("url").Image("image").Description("description")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestHtmlHelperExtensions.Pin(IPinterestHtmlHelper, Action{IPinterestPinWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void Pin_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestHtmlHelperExtensions.Pin(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new PinterestHtmlHelper().Pin(null));

      Assert.Equal(new PinterestHtmlHelper().Pin().ToHtmlString(), new PinterestHtmlHelper().Pin(x => { }));
      Assert.Equal(new PinterestHtmlHelper().Pin().Id("id").ToHtmlString(), new PinterestHtmlHelper().Pin(x => x.Id("id")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestHtmlHelperExtensions.Profile(IPinterestHtmlHelper, Action{IPinterestProfileWidget}"/> method.</para>
    /// </summary>
    [Fact]
    public void Profile_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestHtmlHelperExtensions.Profile(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new PinterestHtmlHelper().Profile(null));

      Assert.Equal(new PinterestHtmlHelper().Profile().ToHtmlString(), new PinterestHtmlHelper().Profile(x => { }));
      Assert.Equal(new PinterestHtmlHelper().Profile().Account("account").ToHtmlString(), new PinterestHtmlHelper().Profile(x => x.Account("account")));
    }
  }
}