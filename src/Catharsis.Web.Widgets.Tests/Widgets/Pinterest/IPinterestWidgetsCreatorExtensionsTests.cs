using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IPinterestWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetsCreatorExtensions.Board(IPinterestWidgetsCreator, Action{IPinterestBoardWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetsCreatorExtensions.Board(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetsCreator().Board(null));

    Assert.Equal(new PinterestWidgetsCreator().Board().ToHtml(), new CackleWidgetsCreator().Comments(_ => { }));
    Assert.Equal(new PinterestWidgetsCreator().Board().Account("account").Id("id").ToHtml(), new PinterestWidgetsCreator().Board(x => x.Account("account").Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetsCreatorExtensions.FollowButton(IPinterestWidgetsCreator, Action{IPinterestFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetsCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetsCreator().FollowButton(null));

    Assert.Equal(new PinterestWidgetsCreator().FollowButton().ToHtml(), new PinterestWidgetsCreator().FollowButton(_ => { }));
    Assert.Equal(new PinterestWidgetsCreator().FollowButton().Account("account").ToHtml(), new PinterestWidgetsCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetsCreatorExtensions.PinItButton(IPinterestWidgetsCreator, Action{IPinterestPinItButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetsCreatorExtensions.PinItButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetsCreator().PinItButton(null));

    Assert.Equal(new PinterestWidgetsCreator().PinItButton().ToHtml(), new PinterestWidgetsCreator().PinItButton(_ => { }));
    Assert.Equal(new PinterestWidgetsCreator().PinItButton().Url("url").Image("image").Description("description").ToHtml(), new PinterestWidgetsCreator().PinItButton(x => x.Url("url").Image("image").Description("description")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetsCreatorExtensions.Pin(IPinterestWidgetsCreator, Action{IPinterestPinWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetsCreatorExtensions.Pin(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetsCreator().Pin(null));

    Assert.Equal(new PinterestWidgetsCreator().Pin().ToHtml(), new PinterestWidgetsCreator().Pin(_ => { }));
    Assert.Equal(new PinterestWidgetsCreator().Pin().Id("id").ToHtml(), new PinterestWidgetsCreator().Pin(x => x.Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetsCreatorExtensions.Profile(IPinterestWidgetsCreator, Action{IPinterestProfileWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetsCreatorExtensions.Profile(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetsCreator().Profile(null));

    Assert.Equal(new PinterestWidgetsCreator().Profile().ToHtml(), new PinterestWidgetsCreator().Profile(_ => { }));
    Assert.Equal(new PinterestWidgetsCreator().Profile().Account("account").ToHtml(), new PinterestWidgetsCreator().Profile(x => x.Account("account")));
  }
}