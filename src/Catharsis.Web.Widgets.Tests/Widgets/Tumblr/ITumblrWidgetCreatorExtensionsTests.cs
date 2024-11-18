using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ITumblrWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class ITumblrWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrWidgetCreatorExtensions.FollowButton(ITumblrWidgetCreator, Action{ITumblrFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITumblrWidgetCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TumblrWidgetCreator().FollowButton(null));

    Assert.Equal(new TumblrWidgetCreator().FollowButton().ToHtml(), new TumblrWidgetCreator().FollowButton(_ => { }));
    Assert.Equal(new TumblrWidgetCreator().FollowButton().Account("account").ToHtml(), new TumblrWidgetCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrWidgetCreatorExtensions.ShareButton(ITumblrWidgetCreator, Action{ITumblrShareButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Share_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITumblrWidgetCreatorExtensions.ShareButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TumblrWidgetCreator().ShareButton(null));

    Assert.Equal(new TumblrWidgetCreator().ShareButton().ToHtml(), new TumblrWidgetCreator().ShareButton(_ => { }));
    Assert.Equal(new TumblrWidgetCreator().ShareButton().Type(TumblrShareButtonType.First).ToHtml(), new TumblrWidgetCreator().ShareButton(x => x.Type(TumblrShareButtonType.First)));
  }
}