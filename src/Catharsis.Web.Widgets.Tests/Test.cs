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
    Fixture
      .TypeRelay<IAddThisFollowButtonsWidget, AddThisFollowButtonsWidget>()
      .TypeRelay<IAddThisShareButtonsWidget, AddThisShareButtonsWidget>()
      .TypeRelay<IAddThisSmartLayersWidget, AddThisSmartLayersWidget>()
      .TypeRelay<IAddThisTrendingContentWidget, AddThisTrendingContentWidget>()
      .TypeRelay<IAddThisWelcomeBarWidget, AddThisWelcomeBarWidget>()
      .TypeRelay<ICackleCommentsCountWidget, CackleCommentsCountWidget>()
      .TypeRelay<ICackleCommentsWidget, CackleCommentsWidget>()
      .TypeRelay<ICackleLatestCommentsWidget, CackleLatestCommentsWidget>()
      .TypeRelay<ICackleLoginWidget, CackleLoginWidget>()
      .TypeRelay<IDisqusCommentsWidget, DisqusCommentsWidget>()
      .TypeRelay<IDoubleGisContactsMapWidget, DoubleGisContactsMapWidget>()
      .TypeRelay<IDoubleGisMapWidget, DoubleGisMapWidget>()
      .TypeRelay<IDoubleGisMiniMapWidget, DoubleGisMiniMapWidget>()
      .TypeRelay<IFacebookActivityFeedWidget, FacebookActivityFeedWidget>()
      .TypeRelay<IFacebookCommentsWidget, FacebookCommentsWidget>()
      .TypeRelay<IFacebookFacePileWidget, FacebookFacePileWidget>()
      .TypeRelay<IFacebookFollowButtonWidget, FacebookFollowButtonWidget>()
      .TypeRelay<IFacebookInitializationWidget, FacebookInitializationWidget>()
      .TypeRelay<IFacebookLikeBoxWidget, FacebookLikeBoxWidget>()
      .TypeRelay<IFacebookLikeButtonWidget, FacebookLikeButtonWidget>()
      .TypeRelay<IFacebookPostWidget, FacebookPostWidget>()
      .TypeRelay<IFacebookRecommendationsFeedWidget, FacebookRecommendationsFeedWidget>()
      .TypeRelay<IFacebookSendButtonWidget, FacebookSendButtonWidget>()
      .TypeRelay<IFacebookVideoWidget, FacebookVideoWidget>()
      .TypeRelay<IGoogleAnalyticsWidget, GoogleAnalyticsWidget>()
      .TypeRelay<IGoogleMapWidget, GoogleMapWidget>()
      .TypeRelay<IGooglePlusOneButtonWidget, GooglePlusOneButtonWidget>()
      .TypeRelay<IGravatarImageUrlWidget, GravatarImageUrlWidget>()
      .TypeRelay<IGravatarProfileUrlWidget, GravatarProfileUrlWidget>()
      .TypeRelay<IInlineImageWidget, InlineImageWidget>()
      .TypeRelay<IIntenseDebateCommentsWidget, IntenseDebateCommentsWidget>()
      .TypeRelay<IIntenseDebateLinkWidget, IntenseDebateLinkWidget>()
      .TypeRelay<ILiveJournalLikeButtonWidget, LiveJournalLikeButtonWidget>()
      .TypeRelay<ILiveJournalRepostButtonWidget, LiveJournalRepostButtonWidget>()
      .TypeRelay<IMailRuFacesWidget, MailRuFacesWidget>()
      .TypeRelay<IMailRuGroupsWidget, MailRuGroupsWidget>()
      .TypeRelay<IMailRuIcqWidget, MailRuIcqWidget>()
      .TypeRelay<IMailRuLikeButtonWidget, MailRuLikeButtonWidget>()
      .TypeRelay<IMailRuVideoWidget, MailRuVideoWidget>()
      .TypeRelay<IPayPalBuyGiftCertificateWidget, PayPalBuyGiftCertificateWidget>()
      .TypeRelay<IPayPalBuyNowWidget, PayPalBuyNowWidget>()
      .TypeRelay<IPayPalDonateWidget, IPayPalDonateWidget>()
      .TypeRelay<IPayPalSubscribeWidget, PayPalSubscribeWidget>()
      .TypeRelay<IPinterestBoardWidget, PinterestBoardWidget>()
      .TypeRelay<IPinterestFollowButtonWidget, PinterestFollowButtonWidget>()
      .TypeRelay<IPinterestPinItButtonWidget, PinterestPinItButtonWidget>()
      .TypeRelay<IPinterestPinWidget, PinterestPinWidget>()
      .TypeRelay<IPinterestProfileWidget, PinterestProfileWidget>()
      .TypeRelay<IRobokassaPaymentFormWidget, RobokassaPaymentFormWidget>()
      .TypeRelay<IRuTubeVideoWidget, RuTubeVideoWidget>()
      .TypeRelay<IShare42PanelWidget, Share42PanelWidget>()
      .TypeRelay<ISoundCloudProfileIconWidget, SoundCloudProfileIconWidget>()
      .TypeRelay<ISurfingbirdSurfButtonWidget, SurfingbirdSurfButtonWidget>()
      .TypeRelay<ITumblrFollowButtonWidget, TumblrFollowButtonWidget>()
      .TypeRelay<ITumblrShareButtonWidget, TumblrShareButtonWidget>()
      .TypeRelay<ITwitterFollowButtonWidget, TwitterFollowButtonWidget>()
      .TypeRelay<ITwitterTweetButtonWidget, TwitterTweetButtonWidget>()
      .TypeRelay<IVideoJSPlayerWidget, VideoJSPlayerWidget>()
      .TypeRelay<IVimeoVideoWidget, VimeoVideoWidget>()
      .TypeRelay<IVkontakteAuthButtonWidget, VkontakteAuthButtonWidget>()
      .TypeRelay<IVkontakteCommentsWidget, VkontakteCommentsWidget>()
      .TypeRelay<IVkontakteCommunityWidget, VkontakteCommunityWidget>()
      .TypeRelay<IVkontakteInitializationWidget, VkontakteInitializationWidget>()
      .TypeRelay<IVkontakteLikeButtonWidget, VkontakteLikeButtonWidget>()
      .TypeRelay<IVkontaktePollWidget, VkontaktePollWidget>()
      .TypeRelay<IVkontaktePostWidget, VkontaktePostWidget>()
      .TypeRelay<IVkontakteRecommendationsWidget, VkontakteRecommendationsWidget>()
      .TypeRelay<IVkontakteSubscriptionWidget, VkontakteSubscriptionWidget>()
      .TypeRelay<IVkontakteVideoWidget, VkontakteVideoWidget>()
      .TypeRelay<IYandexAnalyticsWidget, YandexAnalyticsWidget>()
      .TypeRelay<IYandexLikeButtonWidget, YandexLikeButtonWidget>()
      .TypeRelay<IYandexMapWidget, YandexMapWidget>()
      .TypeRelay<IYandexMoneyButtonWidget, YandexMoneyButtonWidget>()
      .TypeRelay<IYandexMoneyDonateFormWidget, YandexMoneyDonateFormWidget>()
      .TypeRelay<IYandexMoneyPaymentFormWidget, YandexMoneyPaymentFormWidget>()
      .TypeRelay<IYandexSharePanelWidget, YandexSharePanelWidget>()
      .TypeRelay<IYandexVideoWidget, YandexVideoWidget>()
      .TypeRelay<IYouTubeVideoWidget, YouTubeVideoWidget>();

    JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
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