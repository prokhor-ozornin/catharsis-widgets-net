using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class PinterestWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetCreatorExtensions.Board(IPinterestWidgetCreator, Action{IPinterestBoardWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Board_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetCreatorExtensions.Board(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetCreator().Board(null));

    Assert.Equal(new PinterestWidgetCreator().Board().ToHtml(), new CackleWidgetsCreator().Comments(_ => { }));
    Assert.Equal(new PinterestWidgetCreator().Board().Account("account").Id("id").ToHtml(), new PinterestWidgetCreator().Board(x => x.Account("account").Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetCreatorExtensions.FollowButton(IPinterestWidgetCreator, Action{IPinterestFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetCreator().FollowButton(null));

    Assert.Equal(new PinterestWidgetCreator().FollowButton().ToHtml(), new PinterestWidgetCreator().FollowButton(_ => { }));
    Assert.Equal(new PinterestWidgetCreator().FollowButton().Account("account").ToHtml(), new PinterestWidgetCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetCreatorExtensions.PinItButton(IPinterestWidgetCreator, Action{IPinterestPinItButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void PinItButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetCreatorExtensions.PinItButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetCreator().PinItButton(null));

    Assert.Equal(new PinterestWidgetCreator().PinItButton().ToHtml(), new PinterestWidgetCreator().PinItButton(_ => { }));
    Assert.Equal(new PinterestWidgetCreator().PinItButton().Url("url").Image("image").Description("description").ToHtml(), new PinterestWidgetCreator().PinItButton(x => x.Url("url").Image("image").Description("description")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetCreatorExtensions.Pin(IPinterestWidgetCreator, Action{IPinterestPinWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Pin_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetCreatorExtensions.Pin(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetCreator().Pin(null));

    Assert.Equal(new PinterestWidgetCreator().Pin().ToHtml(), new PinterestWidgetCreator().Pin(_ => { }));
    Assert.Equal(new PinterestWidgetCreator().Pin().Id("id").ToHtml(), new PinterestWidgetCreator().Pin(x => x.Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestWidgetCreatorExtensions.Profile(IPinterestWidgetCreator, Action{IPinterestProfileWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Profile_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IPinterestWidgetCreatorExtensions.Profile(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new PinterestWidgetCreator().Profile(null));

    Assert.Equal(new PinterestWidgetCreator().Profile().ToHtml(), new PinterestWidgetCreator().Profile(_ => { }));
    Assert.Equal(new PinterestWidgetCreator().Profile().Account("account").ToHtml(), new PinterestWidgetCreator().Profile(x => x.Account("account")));
  }
}