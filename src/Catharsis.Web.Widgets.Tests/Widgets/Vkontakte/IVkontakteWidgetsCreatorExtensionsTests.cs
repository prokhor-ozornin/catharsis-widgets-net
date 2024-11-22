using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.AuthButton(IVkontakteWidgetsCreator, Action{IVkontakteAuthButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void AuthButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.AuthButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().AuthButton(null));

    Assert.Equal(new VkontakteWidgetsCreator().AuthButton().ToHtml(), new VkontakteWidgetsCreator().AuthButton(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().AuthButton().Standard("url").ToHtml(), new VkontakteWidgetsCreator().AuthButton(x => x.Standard("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Initialize(IVkontakteWidgetsCreator, Action{IVkontakteInitializationWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Initialize(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Initialize(null));

    Assert.Equal(new VkontakteWidgetsCreator().Initialize().ToHtml(), new VkontakteWidgetsCreator().Initialize(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Initialize().ApiId("apiId").ToHtml(), new VkontakteWidgetsCreator().Initialize(x => x.ApiId("apiId")));
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Comments(IVkontakteWidgetsCreator, Action{IVkontakteCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Comments(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Comments(null));

    Assert.Equal(new VkontakteWidgetsCreator().Comments().ToHtml(), new VkontakteWidgetsCreator().Comments(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Comments().Attach(VkontakteCommentsAttach.All).ToHtml(), new VkontakteWidgetsCreator().Comments(x => x.Attach(VkontakteCommentsAttach.All)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Community(IVkontakteWidgetsCreator, Action{IVkontakteCommunityWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Community(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Community(null));

    Assert.Equal(new VkontakteWidgetsCreator().Community().ToHtml(), new VkontakteWidgetsCreator().Community(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Community().Account("account").ToHtml(), new VkontakteWidgetsCreator().Community(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.LikeButton(IVkontakteWidgetsCreator, Action{IVkontakteLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.LikeButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().LikeButton(null));

    Assert.Equal(new VkontakteWidgetsCreator().LikeButton().ToHtml(), new VkontakteWidgetsCreator().LikeButton(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().LikeButton().Text("text").ToHtml(), new VkontakteWidgetsCreator().LikeButton(x => x.Text("text")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Poll(IVkontakteWidgetsCreator, Action{IVkontaktePollWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Poll(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Poll(null));

    Assert.Equal(new VkontakteWidgetsCreator().Poll().ToHtml(), new VkontakteWidgetsCreator().Poll(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Poll().Id("id").ToHtml(), new VkontakteWidgetsCreator().Poll(x => x.Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Post(IVkontakteWidgetsCreator, Action{IVkontaktePostWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Post(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Post(null));

    Assert.Equal(new VkontakteWidgetsCreator().Post().ToHtml(), new VkontakteWidgetsCreator().Post(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Post().Id("id").Owner("owner").Hash("hash").ToHtml(), new VkontakteWidgetsCreator().Post(x => x.Id("id").Owner("owner").Hash("hash")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Recommendations(IVkontakteWidgetsCreator, Action{IVkontakteRecommendationsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Recommendations(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Recommendations(null));

    Assert.Equal(new VkontakteWidgetsCreator().Recommendations().ToHtml(), new VkontakteWidgetsCreator().Recommendations(_ => { }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Subscription(IVkontakteWidgetsCreator, Action{IVkontakteSubscriptionWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscription_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Subscription(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Subscription(null));

    Assert.Equal(new VkontakteWidgetsCreator().Subscription().ToHtml(), new VkontakteWidgetsCreator().Subscription(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Subscription().Account("account").ToHtml(), new VkontakteWidgetsCreator().Subscription(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetsCreatorExtensions.Video(IVkontakteWidgetsCreator, Action{IVkontakteVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetsCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetsCreator().Video(null));

    Assert.Equal(new VkontakteWidgetsCreator().Video().ToHtml(), new VkontakteWidgetsCreator().Video(_ => { }));
    Assert.Equal(new VkontakteWidgetsCreator().Video().Id("id").ToHtml(), new VkontakteWidgetsCreator().Video(x => x.Id("id")));
  }
}