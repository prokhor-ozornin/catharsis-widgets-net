using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.AuthButton(IVkontakteWidgetCreator, Action{IVkontakteAuthButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void AuthButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.AuthButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().AuthButton(null));

    Assert.Equal(new VkontakteWidgetCreator().AuthButton().ToHtml(), new VkontakteWidgetCreator().AuthButton(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().AuthButton().Standard("url").ToHtml(), new VkontakteWidgetCreator().AuthButton(x => x.Standard("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Initialize(IVkontakteWidgetCreator, Action{IVkontakteInitializationWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Initialize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Initialize(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Initialize(null));

    Assert.Equal(new VkontakteWidgetCreator().Initialize().ToHtml(), new VkontakteWidgetCreator().Initialize(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Initialize().ApiId("apiId").ToHtml(), new VkontakteWidgetCreator().Initialize(x => x.ApiId("apiId")));
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Comments(IVkontakteWidgetCreator, Action{IVkontakteCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Comments(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Comments(null));

    Assert.Equal(new VkontakteWidgetCreator().Comments().ToHtml(), new VkontakteWidgetCreator().Comments(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Comments().Attach(VkontakteCommentsAttach.All).ToHtml(), new VkontakteWidgetCreator().Comments(x => x.Attach(VkontakteCommentsAttach.All)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Community(IVkontakteWidgetCreator, Action{IVkontakteCommunityWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Community_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Community(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Community(null));

    Assert.Equal(new VkontakteWidgetCreator().Community().ToHtml(), new VkontakteWidgetCreator().Community(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Community().Account("account").ToHtml(), new VkontakteWidgetCreator().Community(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.LikeButton(IVkontakteWidgetCreator, Action{IVkontakteLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.LikeButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().LikeButton(null));

    Assert.Equal(new VkontakteWidgetCreator().LikeButton().ToHtml(), new VkontakteWidgetCreator().LikeButton(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().LikeButton().Text("text").ToHtml(), new VkontakteWidgetCreator().LikeButton(x => x.Text("text")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Poll(IVkontakteWidgetCreator, Action{IVkontaktePollWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Poll_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Poll(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Poll(null));

    Assert.Equal(new VkontakteWidgetCreator().Poll().ToHtml(), new VkontakteWidgetCreator().Poll(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Poll().Id("id").ToHtml(), new VkontakteWidgetCreator().Poll(x => x.Id("id")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Post(IVkontakteWidgetCreator, Action{IVkontaktePostWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Post_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Post(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Post(null));

    Assert.Equal(new VkontakteWidgetCreator().Post().ToHtml(), new VkontakteWidgetCreator().Post(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Post().Id("id").Owner("owner").Hash("hash").ToHtml(), new VkontakteWidgetCreator().Post(x => x.Id("id").Owner("owner").Hash("hash")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Recommendations(IVkontakteWidgetCreator, Action{IVkontakteRecommendationsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Recommendations(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Recommendations(null));

    Assert.Equal(new VkontakteWidgetCreator().Recommendations().ToHtml(), new VkontakteWidgetCreator().Recommendations(_ => { }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Subscription(IVkontakteWidgetCreator, Action{IVkontakteSubscriptionWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscription_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Subscription(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Subscription(null));

    Assert.Equal(new VkontakteWidgetCreator().Subscription().ToHtml(), new VkontakteWidgetCreator().Subscription(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Subscription().Account("account").ToHtml(), new VkontakteWidgetCreator().Subscription(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteWidgetCreatorExtensions.Video(IVkontakteWidgetCreator, Action{IVkontakteVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontakteWidgetCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new VkontakteWidgetCreator().Video(null));

    Assert.Equal(new VkontakteWidgetCreator().Video().ToHtml(), new VkontakteWidgetCreator().Video(_ => { }));
    Assert.Equal(new VkontakteWidgetCreator().Video().Id("id").ToHtml(), new VkontakteWidgetCreator().Video(x => x.Id("id")));
  }
}