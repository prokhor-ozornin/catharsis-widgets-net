This library is a .NET port of [Catharsis Social Web Widgets](https://github.com/prokhor-ozornin/Catharsis-Social-Web-Widgets) library for ASP.NET MVC platform.

It provides useful social media widgets to include on web pages of your site. 

Web widgets are implemented as C# POCO objects that implement `System.Web.IHtmlString` and provide convenient fluent interface to work with. Extension methods for `System.Web.Mvc.HtmlHelper` for easiness of rendering are also provided as well.

***

**Support**

This project needs your support for further developments ! Please consider donating.

- _Yandex.Money_ : 41001577953208

- _WebMoney (WMR)_ : R399275865890

[![Image](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=APHM8MU9N76V8 "Donate")

***

**Installation and usage**

* Make sure _~/Scripts/WebWidgets_ directory with necessary JavaScript files is copied to the _~/Scripts_ directory of your ASP.NET MVC project.

* Register required JavaScript bundles within your web application in `Global.asax.cs` file (`Application_Start` method) :

`Catharsis.Web.Widgets.WidgetsBundleConfig.RegisterBundles(BundleTable.Bundles);`

* Use extension methods for `System.Web.Mvc.HtmlHelper` class to render web widgets where required, using fluent interface syntax :

`@Html.YouTube().Video().Id("eYJSlHiXegI").Width("320").Height("240")`

You can use lambda delegates as well :

`@Html.YouTube().Video(x => x.Id("eYJSlHiXegI").Width("320").Height("240")))`

Or create and render widgets directly :

`@Html.Raw(new YouTubeVideoWidget().Id("eYJSlHiXegI").Width("320").Height("240"))`

***

**Code Example**

The simplest .cshtml file (ASP.NET MVC view) that makes use of the library may look like the following :

`@using Catharsis.Web.Widgets`

`<html>`

  `<head></head>`

  `<body>`

    `@RenderBody()`

    `@Html.Cackle().Comments().Account("20049") @* Render HTML code for Cackle Comments widget. *@`

    `@WebWidgetsScripts.Render().Cackle() @* Include required local Cackle javascript file from ~/Scripts/WebWidgets directory. Note : not all widgets require JavaScript files.` *@`

  `</body>`

`</html>`

***

**API examples**

**Cackle**

**1. Comments**

_Requirements:_ `WebWidgetsScripts.Render().Cackle()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Cackle().Comments().Account("20049")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dece_4254dc0d_orig)

**2. Comments count hyperlink**

_Requirements:_ `WebWidgetsScripts.Render().Cackle()` JavaScript bundle (_head_ or _body_ section)

_Note:_ Hyperlinks must have a specific CSS class for this to work, as described in Cackle documentation.

_Code:_

`@Html.Cackle().CommentsCount().Account("20049")`

**3. Latest comments**

_Requirements:_ `WebWidgetsScripts.Render().Cackle()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Cackle().LatestComments().Account("20049")`

`@Html.Cackle().LatestComments().Account("20049").Max(15).AvatarSize(32).TitleSize(50).TextSize(255)`

**4. OAuth login**

_Requirements:_ `WebWidgetsScripts.Render().Cackle()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Cackle().Login().Account("20049")`

**Disqus**

**1. Comments**

_Requirements:_ `WebWidgetsScripts.Render().Disqus()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Disqus().Comments().Account("v-svete-snov")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8decd_52c79adf_orig)

**Facebook**

**1. JS API initialization**

_Requirements:_ None

_Code:_

`@Html.Facebook().Initialize().AppId("1437917246425293")`

**2. Activity Feed**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().ActivityFeed()`

`@Html.Facebook().ActivityFeed().Domain("yandex.ru")`

`@Html.Facebook().ActivityFeed().Domain("yandex.ru").Header(false).Recommendations().ColorScheme(FacebookColorScheme.Dark)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8decf_7b4f254a_orig)

**3. Recommendations Feed**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().RecommendationsFeed()`

`@Html.Facebook().RecommendationsFeed().Domain("yandex.ru")`

`@Html.Facebook().RecommendationsFeed().Domain("yandex.ru").Header(false).ColorScheme(FacebookColorScheme.Dark)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8ded5_c2a1df46_orig)

**4. Comments**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().Comments()`

`@Html.Facebook().Comments().Url("http://yandex.ru")`

`@Html.Facebook().Comments().Url("http://yandex.ru").Order(FacebookCommentsOrder.ReverseTime).Posts(1).Width("500")`

![](http://img-fotki.yandex.ru/get/9822/80185211.1d/0_8ded0_864544eb_orig)

**5. Facepile**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().Facepile()`

`@Html.Facebook().Facepile().Url("http://yandex.ru")`

`@Html.Facebook().Facepile().Url("http://yandex.ru").MaxRows(5).PhotoSize(FacebookFacepilePhotoSize.Large).Height("300")`

**6. Follow Button**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().FollowButton().Url("http://www.facebook.com/zuck")`

`@Html.Facebook().FollowButton().Url("http://www.facebook.com/zuck").KidsMode().Faces().Layout(FacebookButtonLayout.BoxCount)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8ded1_e4885846_orig)

**7. Like Box**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().LikeBox().Url("https://www.facebook.com/pages/Clear-Words/515749945120070")`

`@Html.Facebook().LikeBox().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Header(false).Border(false).Faces(false).Stream().Width("500")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8ded2_e76aa4ec_orig)

**8. Like Button**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().LikeButton()`

`@Html.Facebook().LikeButton().Url("http://yandex.ru")`

`@Html.Facebook().LikeButton().Url("http://yandex.ru").Layout(FacebookLikeButtonLayout.BoxCount).Faces().Verb(FacebookLikeButtonVerb.Recommend)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8ded3_38a5cbe9_orig)

**9. Embedded post**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().Post().Url("https://www.facebook.com/prokhor.ozornin/posts/10203109769053557").Width(640)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8ded4_d52c9373_orig)

**10. Send Button**

_Requirements:_ Call to `Html.Facebook().Initialize()`

_Code:_

`@Html.Facebook().SendButton()`

`@Html.Facebook().SendButton().Url("http://yandex.ru")`

`@Html.Facebook().SendButton().Url("http://yandex.ru").ColorScheme(FacebookColorScheme.Dark).KidsMode()`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8ded6_4da589ba_orig)

**11. Embedded video**

_Requirements:_ None

_Code:_

`@Html.Facebook().Video().Height("480").Width("640").Id("10203121281421359")`

![](http://img-fotki.yandex.ru/get/9491/80185211.1e/0_8df01_d86a4cce_orig)

**Google**

**1. Analytics**

_Requirements:_ None

_Code:_

`@Html.Google().Analytics().Domain("v-svete-snov.ru").Account("UA-27123759-16")`

![](http://img-fotki.yandex.ru/get/9822/80185211.1d/0_8ded7_a5f7153d_orig)

**2. +1 Button**

_Requirements:_ `WebWidgetsScripts.Render().Google()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Google().PlusOneButton()`

`@Html.Google().PlusOneButton().Url("http://yandex.ru").Alignment(GooglePlusOneButtonAlignment.Right).Size(GooglePlusOneButtonSize.Tall).Annotation(GooglePlusOneButtonAnnotation.Inline).Recommendations(false)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8ded8_426fde9_orig)

**Gravatar**

**1. Avatar image URL**

_Requirements:_ None

_Code:_

`@Html.Gravatar().ImageUrl().Email("prokhor.ozornin@yandex.ru")`

`@Html.Gravatar().ImageUrl().Email("prokhor.ozornin@yandex.ru").Extension("jpg").ForceDefault().Size(320)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8ded9_af2ee96e_orig)

**2. User profile URL**

_Requirements:_ None

_Code:_

`@Html.Gravatar().ProfileUrl().Email("prokhor.ozornin@yandex.ru")`

`@Html.Gravatar().ProfileUrl().Email("prokhor.ozornin@yandex.ru").Xml()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8deda_4837ca1b_orig)

**IntenseDebate**

**1. Comments**

_Requirements:_ None

_Code:_

`@Html.IntenseDebate().Comments().Account("a639ec3507d53023d4f213666651b6c2")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dedb_af15dfff_orig)

**2. Comments count hyperlink**

_Requirements:_ None

_Code:_

`@Html.IntenseDebate().Link().Account("a639ec3507d53023d4f213666651b6c2")`

**LiveJournal**

**1. Like Button**

_Requirements:_ None

_Code:_

`@Html.LiveJournal().LikeButton()`

**2. Repost Button**

_Requirements:_ None

_Code:_

`@Html.LiveJournal().RepostButton()`

`@Html.LiveJournal().RepostButton().Title("title").Text("text")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dedc_e64cb946_orig)

**Mail.ru**

**1. ICQ On-Site**

_Requirements:_ None

_Code:_

`@Html.MailRu().Icq()`

`@Html.MailRu().Icq().Account("12345678").Language("en")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dedf_48c0f729_orig)

**2. Embedded video**

_Requirements:_ None

_Code:_

`@Html.MailRu().Video().Id("i.v.sosnin62/3023/3027.html").Height("480").Width("640")`

**3. Like Button**

_Requirements:_ `WebWidgetsScripts.Render().MailRu()` JavaScript bundle (_body_ section)

_Code:_

`@Html.MailRu().LikeButton()`

`@Html.MailRu().LikeButton().Layout(MailRuLikeButtonLayout.Second).Text(false).CounterPosition(MailRuLikeButtonCounterPosition.Upper).Size(30)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dee0_ab70e64f_orig)

**4. Faces**

_Requirements:_ `WebWidgetsScripts.Render().MailRu()` JavaScript bundle (_body_ section)

_Code:_

`@Html.MailRu().Faces().Domain("mail.ru").Width(640).Height(480)`

`@Html.MailRu().Faces().Domain("mail.ru").Width(640).Height(480).Font(MailRuFacesFont.Tahoma).Title(false).BackgroundColor("aaffaa").HyperlinkColor("ffaaff").BorderColor("aaaaaa")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dedd_1e4bea58_orig)

**5. Groups**

_Requirements:_ `WebWidgetsScripts.Render().MailRu()` JavaScript bundle (_body_ section)

_Code:_

`@Html.MailRu().Groups().Account("mail_ru").Width(640).Height(480)`

`@Html.MailRu().Groups().Account("mail_ru").Width(640).Height(480).BackgroundColor("aaffaa").ButtonColor("ffaaff").Subscribers(false).TextColor("aaaadd")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8dede_dcf4ba5a_orig)

**Pinterest**

**1. Follow Button**

_Requirements:_ `WebWidgetsScripts.Render().Pinterest()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Pinterest().FollowButton().Account("pinterest")`

`@Html.Pinterest().FollowButton().Account("pinterest").Label("Pinterest")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8dee2_b4b37dac_orig)

**2. Embedded Pin**

_Requirements:_ `WebWidgetsScripts.Render().Pinterest()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Pinterest().Pin().Id("99360735500167749")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8dee3_be322660_orig)

**3. Board**

_Requirements:_ `WebWidgetsScripts.Render().Pinterest()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Pinterest().Board().Account("pinterest").Id("pin-pets")`

`@Html.Pinterest().Board().Account("pinterest").Id("pin-pets").Sidebar()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dee1_71b1ce7d_orig)

**4. Profile**

_Requirements:_ `WebWidgetsScripts.Render().Pinterest()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Pinterest().Profile().Account("pinterest")`

`@Html.Pinterest().Profile().Account("pinterest").Sidebar()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dee5_6a6520e5_orig)

**5. Pin It Button**

_Requirements:_ `WebWidgetsScripts.Render().Pinterest()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Pinterest().PinItButton().Url("http://www.flickr.com/photos/kentbrew/6851755809").Image("http://farm8.staticflickr.com/7027/6851755809_df5b2051c9_z.jpg").Description("Next stop: Pinterest")`

`@Html.Pinterest().PinItButton().Url("http://www.flickr.com/photos/kentbrew/6851755809").Image("http://farm8.staticflickr.com/7027/6851755809_df5b2051c9_z.jpg").Description("Next stop: Pinterest").Counter(PinterestPinItButtonPinCountPosition.None).Size(PinterestPinItButtonSize.Large).Red().Shape(PinterestPinItButtonShape.Rectangular).Language("ja")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8dee4_3a2af139_orig)

**RuTube**

**1. Embedded video**

_Requirements:_ None

_Code:_

`@Html.RuTube().Video().Id("6785018").Height("480").Width("640")`

![](http://img-fotki.yandex.ru/get/9822/80185211.1d/0_8dee6_43358fbd_orig)

**SoundCloud**

**1. User's profile icon**

_Requirements:_ None

_Code:_

`@Html.SoundCloud().ProfileIcon().Account("prokhor-ozornin")`

`@Html.SoundCloud().ProfileIcon().Account("prokhor-ozornin").BlackWhite().Size(SoundCloudProfileIconSize.Size64)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8deed_d181e855_orig)

**Surfingbird**

**1. Surf Button**

_Requirements:_ `WebWidgetsScripts.Render().Surfingbird()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Surfingbird().SurfButton()`

`@Html.Surfingbird().SurfButton().Color(SurfingbirdSurfButtonColor.Blue).Counter().Label("Share").Url("http://yandex.ru").Layout(SurfingbirdSurfButtonLayout.Common)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8dee7_74e3c86c_orig)

**Tumblr**

**1. Follow Button**

_Requirements:_ None

_Code:_

`@Html.Tumblr().FollowButton().Account("clear-words-en")`

`@Html.Tumblr().FollowButton().Account("clear-words-en").ColorScheme(TumblrFollowButtonColorScheme.Dark).Type(TumblrFollowButtonType.Second)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8deea_60c1333d_orig)

**2. Share Button**

_Requirements:_ `WebWidgetsScripts.Render().Tumblr()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Tumblr().ShareButton()`

`@Html.Tumblr().ShareButton().ColorScheme(TumblrShareButtonColorScheme.Gray).Type(TumblrShareButtonType.Third)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dee8_5fd0a553_orig)

**Twitter**

**1. Tweet Button**

_Requirements:_ `WebWidgetsScripts.Render().Twitter()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Twitter().TweetButton()`

`@Html.Twitter().TweetButton().HashTags("first", "second", "third").Url("http://yandex.ru").Text("Let's share it !").Via("Prokhor").Suggestions(false)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8deeb_cd475dfc_orig)

**2. Follow Button**

_Requirements:_ `WebWidgetsScripts.Render().Twitter()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Twitter().FollowButton().Account("prokhor_ozornin")`

`@Html.Twitter().FollowButton().Account("prokhor_ozornin").Suggestions().Counter(false).ScreenName(false)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1d/0_8dee9_39fe8a8c_orig)

**Vimeo**

**1. Embedded video**

_Requirements:_ None

_Code:_

`@Html.Vimeo().Video().Id("55456906").Width("640").Height("480")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1d/0_8deec_a89cc026_orig)

**Vkontakte**

**1. Embedded video**

_Requirements:_ None

_Code:_

`@Html.Vkontakte().Video().Id("167533148").Hash("7a0cdf6ef7a69e67").User("5707198").Width("607").Height("360").Hd()`

![](http://img-fotki.yandex.ru/get/5203/80185211.1e/0_8def8_8c281838_orig)

**2. JS API initialization**

_Requirements:_ `WebWidgetsScripts.Render().Vkontakte()` JavaScript bundle (_head_ section)

_Code:_

`@Html.Vkontakte().Initialize().ApiId("3816272")`

**3. Comments**

_Requirements:_ Call to `Html.Vkontakte().Initialize()`

_Code:_

`@Html.Vkontakte().Comments()`

`@Html.Vkontakte().Comments().Attach(VkontakteCommentsAttach.All).Limit(VkontakteCommentsLimit.Limit15)`

![](http://img-fotki.yandex.ru/get/9822/80185211.1d/0_8deef_1d93c587_orig)

**4. Community**

_Requirements:_ Call to `Html.Vkontakte().Initialize()`

_Code:_

`@Html.Vkontakte().Community().Account("44545550")`

`@Html.Vkontakte().Community().Account("44545550").Mode(VkontakteCommunityMode.News).Height(400).Width(600)`

![](http://img-fotki.yandex.ru/get/5203/80185211.1e/0_8def1_155d6ab8_orig)

**5. Like Button**

_Requirements:_ Call to `Html.Vkontakte().Initialize()`

_Code:_

`@Html.Vkontakte().LikeButton()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8def2_6a491b94_orig)

**6. Subscription**

_Requirements:_ Call to `Html.Vkontakte().Initialize()`

_Code:_

`@Html.Vkontakte().Subscription().Account("5707198")`

`@Html.Vkontakte().Subscription().Account("5707198").OnlyButton()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8def7_62688243_orig)

**Yandex**

**1. Metrika**

_Requirements:_ None

_Code:_

`@Html.Yandex().Analytics().Account("12066574")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8defa_a0bc72d8_orig)

**2. Like Button**

_Requirements:_ None

_Code:_

`@Html.Yandex().LikeButton()`

`@Html.Yandex().LikeButton().Title("Yandex Main Page").Text("Share").Url("http://yandex.ru").Size(YandexLikeButtonSize.Small)`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8def9_dcb28653_orig)

**3. Embedded video**

_Requirements:_ None

_Code:_

`@Html.Yandex().Video().Id("6ea0ugstkx.2528").User("leonevskiy").Width("450").Height("253")`

![](http://img-fotki.yandex.ru/get/5203/80185211.1e/0_8deff_387a5ec2_orig)

**4. Yandex.Money payment button**

_Requirements:_ None

_Code:_

`@Html.Yandex().MoneyButton().Account("41001577953208").Sum(15.5).Description("Test Payment")`

`@Html.Yandex().MoneyButton().Account("41001577953208").Sum(15.5).Description("Test Payment").Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Buy).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).AskPayerAddress().AskPayerEmail().AskPayerFullName().AskPayerPhone()`

![](http://img-fotki.yandex.ru/get/5203/80185211.1e/0_8defb_508fd66c_orig)

**5. Yandex.Money donation form**

_Requirements:_ None

_Code:_

`@Html.Yandex().MoneyDonateForm().Account("41001577953208").DescriptionText("Test Donation")`

`@Html.Yandex().MoneyDonateForm().Account("41001577953208").DescriptionText("Test Donation").Description().Sum(15.5).Cards().ProjectName("Yandex").ProjectSite("http://yandex.ru").Text(YandexMoneyDonateFormText.Give).AskPayerPhone().AskPayerFullName().AskPayerComment().AskPayerEmail()`

![](http://img-fotki.yandex.ru/get/5203/80185211.1e/0_8defc_3a3f4bf0_orig)

**6. Yandex.Money payment form**

_Requirements:_ None

_Code:_

`@Html.Yandex().MoneyPaymentForm().Account("41001577953208").Description("Test Payment")`

`@Html.Yandex().MoneyPaymentForm().Account("41001577953208").Description("Test Payment").Sum(15.5).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).PayerComment().AskPayerEmail().AskPayerFullName().AskPayerAddress().AskPayerPhone().AskPayerPurpose()`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8defd_154be7bd_orig)

**7. Share Button**

_Requirements:_ `WebWidgetsScripts.Render().Yandex()` JavaScript bundle (_head_ or _body_ section)

_Code:_

`@Html.Yandex().SharePanel()`

`@Html.Yandex().SharePanel().Services("facebook").Language("en")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8defe_9ec5f03a_orig)

**YouTube**

**1. Embedded video**

_Requirements:_ None

_Code:_

`@Html.YouTube().Video().Id("eYJSlHiXegI").Width("100%").Height("480")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8df00_839c0d10_orig)

**VideoJS**

**1. Media Player**

_Requirements:_ 

- `WebWidgetsScripts.Render().VideoJS()` JavaScript bundle (_head_ or _body_ section)

- `WebWidgetsStyles.Render().VideoJS()` CSS bundle (_head_ section)

_Code:_

`@Html.VideoJS().Player().Width("640").Height("480").Videos(new MediaSource("http://vjs.zencdn.net/v/oceans.mp4", VideoContentTypes.MP4), new MediaSource("http://vjs.zencdn.net/v/oceans.webm", VideoContentTypes.WebM)).HtmlBody(@"<track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track>")`

![](http://img-fotki.yandex.ru/get/9489/80185211.1e/0_8deee_352bf71e_orig)