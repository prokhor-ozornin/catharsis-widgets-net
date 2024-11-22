using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITumblrWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class ITumblrWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrWidgetsCreatorExtensions.FollowButton(ITumblrWidgetsCreator, Action{ITumblrFollowButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITumblrWidgetsCreatorExtensions.FollowButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TumblrWidgetsCreator().FollowButton(null));

    Assert.Equal(new TumblrWidgetsCreator().FollowButton().ToHtml(), new TumblrWidgetsCreator().FollowButton(_ => { }));
    Assert.Equal(new TumblrWidgetsCreator().FollowButton().Account("account").ToHtml(), new TumblrWidgetsCreator().FollowButton(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrWidgetsCreatorExtensions.ShareButton(ITumblrWidgetsCreator, Action{ITumblrShareButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Share_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITumblrWidgetsCreatorExtensions.ShareButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new TumblrWidgetsCreator().ShareButton(null));

    Assert.Equal(new TumblrWidgetsCreator().ShareButton().ToHtml(), new TumblrWidgetsCreator().ShareButton(_ => { }));
    Assert.Equal(new TumblrWidgetsCreator().ShareButton().Type(TumblrShareButtonType.First).ToHtml(), new TumblrWidgetsCreator().ShareButton(x => x.Type(TumblrShareButtonType.First)));
  }
}