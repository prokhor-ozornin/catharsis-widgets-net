using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using Newtonsoft.Json;

namespace Catharsis.Web.Widgets.Tests;

public class Test : IDisposable
{
  protected IFixture Fixture { get; } = new Fixture();

  protected Test()
  {
    JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

    Fixture
      .Map<IAddThisFollowButtonsWidget, AddThisFollowButtonsWidget>()
      .Map<IAddThisShareButtonsWidget, AddThisShareButtonsWidget>()
      .Map<IAddThisSmartLayersWidget, AddThisSmartLayersWidget>()
      .Map<IAddThisTrendingContentWidget, AddThisTrendingContentWidget>()
      .Map<IAddThisWelcomeBarWidget, AddThisWelcomeBarWidget>()
      .Map<ICackleCommentsCountWidget, CackleCommentsCountWidget>()
      .Map<ICackleCommentsWidget, CackleCommentsWidget>()
      .Map<ICackleLatestCommentsWidget, CackleLatestCommentsWidget>()
      .Map<ICackleLoginWidget, CackleLoginWidget>()
      .Map<IDisqusCommentsWidget, DisqusCommentsWidget>()
      .Map<IDoubleGisContactsMapWidget, DoubleGisContactsMapWidget>()
      .Map<IDoubleGisMapWidget, DoubleGisMapWidget>()
      .Map<IDoubleGisMiniMapWidget, DoubleGisMiniMapWidget>()
      .Map<IFacebookActivityFeedWidget, FacebookActivityFeedWidget>()
      .Map<IFacebookCommentsWidget, FacebookCommentsWidget>()
      .Map<IFacebookFacePileWidget, FacebookFacePileWidget>()
      .Map<IFacebookFollowButtonWidget, FacebookFollowButtonWidget>()
      .Map<IFacebookInitializationWidget, FacebookInitializationWidget>()
      .Map<IFacebookLikeBoxWidget, FacebookLikeBoxWidget>()
      .Map<IFacebookLikeButtonWidget, FacebookLikeButtonWidget>()
      .Map<IFacebookPostWidget, FacebookPostWidget>()
      .Map<IFacebookRecommendationsFeedWidget, FacebookRecommendationsFeedWidget>()
      .Map<IFacebookSendButtonWidget, FacebookSendButtonWidget>()
      .Map<IFacebookVideoWidget, FacebookVideoWidget>()
      .Map<IGoogleAnalyticsWidget, GoogleAnalyticsWidget>()
      .Map<IGoogleMapWidget, GoogleMapWidget>()
      .Map<IGooglePlusOneButtonWidget, GooglePlusOneButtonWidget>()
      .Map<IGravatarImageUrlWidget, GravatarImageUrlWidget>()
      .Map<IGravatarProfileUrlWidget, GravatarProfileUrlWidget>()
      .Map<IInlineImageWidget, InlineImageWidget>()
      .Map<IIntenseDebateCommentsWidget, IntenseDebateCommentsWidget>()
      .Map<IIntenseDebateLinkWidget, IntenseDebateLinkWidget>()
      .Map<ILiveJournalLikeButtonWidget, LiveJournalLikeButtonWidget>()
      .Map<ILiveJournalRepostButtonWidget, LiveJournalRepostButtonWidget>()
      .Map<IMailRuFacesWidget, MailRuFacesWidget>()
      .Map<IMailRuGroupsWidget, MailRuGroupsWidget>()
      .Map<IMailRuIcqWidget, MailRuIcqWidget>()
      .Map<IMailRuLikeButtonWidget, MailRuLikeButtonWidget>()
      .Map<IMailRuVideoWidget, MailRuVideoWidget>()
      .Map<IPayPalBuyGiftCertificateWidget, PayPalBuyGiftCertificateWidget>()
      .Map<IPayPalBuyNowWidget, PayPalBuyNowWidget>()
      .Map<IPayPalDonateWidget, IPayPalDonateWidget>()
      .Map<IPayPalSubscribeWidget, PayPalSubscribeWidget>()
      .Map<IPinterestBoardWidget, PinterestBoardWidget>()
      .Map<IPinterestFollowButtonWidget, PinterestFollowButtonWidget>()
      .Map<IPinterestPinItButtonWidget, PinterestPinItButtonWidget>()
      .Map<IPinterestPinWidget, PinterestPinWidget>()
      .Map<IPinterestProfileWidget, PinterestProfileWidget>()
      .Map<IRobokassaPaymentFormWidget, RobokassaPaymentFormWidget>()
      .Map<IRuTubeVideoWidget, RuTubeVideoWidget>()
      .Map<IShare42PanelWidget, Share42PanelWidget>()
      .Map<ISoundCloudProfileIconWidget, SoundCloudProfileIconWidget>()
      .Map<ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonWidget>()
      .Map<ITumblrFollowButtonWidget, TumblrFollowButtonWidget>()
      .Map<ITumblrShareButtonWidget, TumblrShareButtonWidget>()
      .Map<ITwitterFollowButtonWidget, TwitterFollowButtonWidget>()
      .Map<ITwitterTweetButtonWidget, TwitterTweetButtonWidget>()
      .Map<IVideoJSPlayerWidget, VideoJSPlayerWidget>()
      .Map<IVimeoVideoWidget, VimeoVideoWidget>()
      .Map<IVkontakteAuthButtonWidget, VkontakteAuthButtonWidget>()
      .Map<IVkontakteCommentsWidget, VkontakteCommentsWidget>()
      .Map<IVkontakteCommunityWidget, VkontakteCommunityWidget>()
      .Map<IVkontakteInitializationWidget, VkontakteInitializationWidget>()
      .Map<IVkontakteLikeButtonWidget, VkontakteLikeButtonWidget>()
      .Map<IVkontaktePollWidget, VkontaktePollWidget>()
      .Map<IVkontaktePostWidget, VkontaktePostWidget>()
      .Map<IVkontakteRecommendationsWidget, VkontakteRecommendationsWidget>()
      .Map<IVkontakteSubscriptionWidget, VkontakteSubscriptionWidget>()
      .Map<IVkontakteVideoWidget, VkontakteVideoWidget>()
      .Map<IYandexAnalyticsWidget, YandexAnalyticsWidget>()
      .Map<IYandexLikeButtonWidget, YandexLikeButtonWidget>()
      .Map<IYandexMapWidget, YandexMapWidget>()
      .Map<IYandexMoneyButtonWidget, YandexMoneyButtonWidget>()
      .Map<IYandexMoneyDonateFormWidget, YandexMoneyDonateFormWidget>()
      .Map<IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormWidget>()
      .Map<IYandexSharePanelWidget, YandexSharePanelWidget>()
      .Map<IYandexVideoWidget, YandexVideoWidget>()
      .Map<IYouTubeVideoWidget, YouTubeVideoWidget>();
  }

  public virtual void Dispose()
  {
  }

  protected void TestCompareTo<TClass, TProperty>(string property, TProperty lower, TProperty greater, Func<TClass> constructor = null)
  {
    constructor ??= () => typeof(TClass).Instance<TClass>();

    var first = constructor().To<IComparable<TClass>>();
    var second = constructor().To<TClass>();

    first.SetPropertyValue(property, lower);
    second.SetPropertyValue(property, lower);

    first.CompareTo(second).Should().Be(0);
    second.SetPropertyValue(property, greater);
    first.CompareTo(second).Should().BeLessThan(0);
  }

  protected void TestEquality<TClass, TProperty>(string property, TProperty oldValue, TProperty newValue, Func<TClass> constructor = null)
  {
    constructor ??= () => typeof(TClass).Instance<TClass>();
    var entity = constructor();

    entity.Equals(new object()).Should().BeFalse();
    entity.Equals(null).Should().BeFalse();
    entity.Equals(entity).Should().BeTrue();
    //entity.Equals(constructor()).Should().BeTrue();

    constructor().SetPropertyValue(property, oldValue).Equals(constructor().SetPropertyValue(property, oldValue)).Should().BeTrue();
    constructor().SetPropertyValue(property, oldValue).Equals(constructor().SetPropertyValue(property, newValue)).Should().BeFalse();
  }

  protected void TestHashCode<TClass, TProperty>(string property, TProperty oldValue, TProperty newValue, Func<TClass> constructor = null)
  {
    constructor ??= () => typeof(TClass).Instance<TClass>();
    var entity = constructor();

    entity.GetHashCode().Should().Be(entity.GetHashCode());
    //entity.GetHashCode().Should().Be(constructor().GetHashCode());

    constructor().SetPropertyValue(property, oldValue).GetHashCode().Should().Be(constructor().SetPropertyValue(property, oldValue).GetHashCode());
    constructor().SetPropertyValue(property, oldValue).GetHashCode().Should().NotBe(constructor().SetPropertyValue(property, newValue).GetHashCode());
  }
}