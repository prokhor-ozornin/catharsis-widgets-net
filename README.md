This library is a .NET port of [Catharsis Social Web Widgets](https://github.com/prokhor-ozornin/Catharsis-Social-Web-Widgets) library for ASP.NET MVC platform.

It provides useful social media widgets to include on web pages of your site. 

Web widgets are implemented as C# POCO objects that implement `System.Web.IHtmlString` and provide convenient fluent interface to work with. Extension methods for `System.Web.Mvc.HtmlHelper` for easiness of rendering are also provided as well.

***

**Support**

This project needs your support ! Please donate.

- _Yandex.Money_ : 41001577953208

- _WebMoney (WMR)_ : R399275865890

[image:Donate|https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif|https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=APHM8MU9N76V8]

***

**Installation and usage**

To include this library in your web application, do the following :

* Make sure _~/Scripts/widgets_ directory with necessary JavaScript files is copied to the _~/Scripts_ directory of your ASP.NET MVC project.

* Register required JavaScript bundles within your web application in `Global.asax.cs` file (`Application_Start` method) :

`Catharsis.Web.Widgets.WidgetsBundleConfig.RegisterBundles(BundleTable.Bundles);`

* Add JavaScript bundles to the `<head>` section of your web pages when required as described below. For a typical ASP.NET MVC project this should be placed inside `_Layout.cshtml` file :

`<head>`

  `@Scripts.Render(Catharsis.Web.Widgets.WidgetsScripts.Cackle)`

`</head>`

* Add external JavaScript links to the `<head>` section of your web pages when required as described below. For a typical ASP.NET MVC project this should be placed inside `_Layout.cshtml` file :

`<head>`

  `<script src="@WidgetsScripts.VKontakte" type="text/javascript"></script>`

`</head>`

* Use extension methods for `System.Web.Mvc.HtmlHelper` class to render web widgets where required, using fluent interface syntax :

`@Html.YouTube().Video().Id("eYJSlHiXegI").Width("320").Height("240")`

You can use lambda delegates as well :

`@Html.YouTube().Video(x => x.Id("eYJSlHiXegI").Width("320").Height("240")))`

Or create and render widgets directly :

`@Html.Raw(new YouTubeVideoWidget().Id("eYJSlHiXegI").Width("320").Height("240"))`

***

**Usage examples**

**Cackle**

You must include `WidgetsScriptsBundles.Cackle` JavaScript bundle first to use below widgets.

> Render Cackle comments widget

> `@Html.Cackle().Comments().Account("20049")`

> Render required JavaScript to display number of comments next to hyperlinks. Hyperlinks must have a specific CSS class for this to work, as described in Cackle documentation.

> `@Html.Cackle().CommentsCount().Account("20049")`

> Render Cackle list of latest comments

> `@Html.Cackle().LatestComments().Account("20049")`

> `@Html.Cackle().LatestComments().Account("20049").Max(15).AvatarSize(32).TitleSize(50).TextSize(255)`

> Render Cackle OAuth login widget

> `@Html.Cackle().Login().Account("20049")`

**Disqus**

You must include `WidgetsScriptsBundles.Disqus` JavaScript bundle first to use below widgets.

> Render Disqus comments widget

> `@Html.Disqus().Comments().Account("v-svete-snov")`

> `@Scripts.Render(WidgetsScriptsBundles.Disqus)`

**Facebook**

> Render Facebook embedded video

> `@Html.Facebook().Video().Height("480").Width("640").Id("10203121281421359")`

> Performs Facebook JavaScript API initialization

> `@Html.Facebook().Initialize().AppId("1437917246425293")`

You must include call to `@Html.Facebook().Initialize()` helper first to use below widgets.

> Render Facebook Activity Feed widget

> `@Html.Facebook().ActivityFeed()`

> `@Html.Facebook().ActivityFeed().Domain("yandex.ru")`

> `@Html.Facebook().ActivityFeed().Domain("yandex.ru").Header(false).Recommendations().ColorScheme(FacebookColorScheme.Dark)`

> Render Facebook Recommendations Feed widget

> `@Html.Facebook().RecommendationsFeed()`

> `@Html.Facebook().RecommendationsFeed().Domain("yandex.ru")`

> `@Html.Facebook().RecommendationsFeed().Domain("yandex.ru").Header(false).ColorScheme(FacebookColorScheme.Dark)`

> Render Facebook comments widget

> `@Html.Facebook().Comments()`

> `@Html.Facebook().Comments().Url("http://yandex.ru")`

> `@Html.Facebook().Comments().Url("http://yandex.ru").Order(FacebookCommentsOrder.ReverseTime).Posts(1).Width("500")`

> Render Facebook Facepile widget

> `@Html.Facebook().Facepile()`

> `@Html.Facebook().Facepile().Url("http://yandex.ru")`

> `@Html.Facebook().Facepile().Url("http://yandex.ru").MaxRows(5).Size(FacebookFacepileSize.Large).Height("300")`

> Render Facebook "Follow" button

> `@Html.Facebook().Follow().Url("http://www.facebook.com/zuck")`

> `@Html.Facebook().Follow().Url("http://www.facebook.com/zuck").Kids().Faces().Layout(FacebookButtonLayout.BoxCount)`

> Render Facebook Like Box

> `@Html.Facebook().LikeBox().Url("https://www.facebook.com/pages/Clear-Words/515749945120070")`

> `@Html.Facebook().LikeBox().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Header(false).Border(false).Faces(false).Stream().Width("500")`

> Render Facebook "Like" button

> `@Html.Facebook().Like().Url("http://yandex.ru")`

> `@Html.Facebook().Like().Url("http://yandex.ru").Layout(FacebookLikeButtonLayout.BoxCount).ShowFaces().Verb(FacebookLikeButtonVerb.Recommend)`

> Render Facebook embedded post

> `@Html.Facebook().Post().Url("https://www.facebook.com/prokhor.ozornin/posts/10203109769053557").Width(640)`

> Render Facebook "Send" button

> `@Html.Facebook().Send()`

> `@Html.Facebook().Send().Url("http://yandex.ru")`

> `@Html.Facebook().Send().Url("http://yandex.ru").ColorScheme(FacebookColorScheme.Dark).Kids()`

**Google**

> Render Google Analytics tracking code

> `@Html.Google().Analytics().Domain("v-svete-snov.ru").Account("UA-27123759-16")`

You must include `WidgetsScriptsBundles.Google` JavaScript bundle first to use below widgets.

> Render Google "+1" button

> `@Html.Google().PlusOne()`

> `@Html.Google().PlusOne().Url("http://yandex.ru").Alignment(GooglePlusOneButtonAlignment.Right).Size(GooglePlusOneButtonSize.Tall).Annotation(GooglePlusOneButtonAnnotation.Inline).Recommendations(false)`

**Gravatar**

> Render Gravatar's avatar image URL.

> `@Html.Gravatar().ImageUrl().Email("prokhor.ozornin@yandex.ru")`

> `@Html.Gravatar().ImageUrl().Email("prokhor.ozornin@yandex.ru").Extension("jpg").ForceDefault().Size(320)`

> Render Gravatar's user profile URL.

> `@Html.Gravatar().ProfileUrl().Email("prokhor.ozornin@yandex.ru")`

> `@Html.Gravatar().ProfileUrl().Email("prokhor.ozornin@yandex.ru").Xml()`

**IntenseDebate**

> Render IntenseDebate comments widget

> `@Html.IntenseDebate().Comments().Account("a639ec3507d53023d4f213666651b6c2")`

> Render IntenseDebate hyperlink with comments count

> `@Html.IntenseDebate().Link().Account("a639ec3507d53023d4f213666651b6c2")`

**LiveJournal**

> Renders LiveJournal "Like" button

> `@Html.LiveJournal().Like()`

> Renders LiveJournal "Repost" button

> `@Html.LiveJournal().Repost()`

> `@Html.LiveJournal().Repost().Title("title").Text("text")`

**Mail.ru**

> Render ICQ On-Site widget

> `@Html.MailRu().Icq()`

> `@Html.MailRu().Icq().Account("12345678").Language("en")`

> Render Mail.ru embedded video

> `@Html.MailRu().Video().Id("i.v.sosnin62/3023/3027.html").Height("480").Width("640")`

> Render Mail.ru video hyperlink

> `@Html.MailRu().VideoLink().Id("i.v.sosnin62/3023/3027.html").HtmlBody("Watch Mail.ru video !")`

You must include `<script src="@WidgetsScripts.MailRu" type="text/javascript"></script>` directive in the end of the `<body>` tag to use below widgets.

> Render Mail.ru + Odnoklassniki.ru "Like" buttons pair

> `@Html.MailRu().Like()`

> `@Html.MailRu().Like().Layout(MailRuLikeButtonLayout.Second).HasText(false).CounterPosition(MailRuLikeButtonCounterPosition.Upper).Size(30)`

> Renders Mail.ru Faces (People On Site) widget.

> `@Html.MailRu().Faces().Domain("mail.ru").Width(640).Height(480)`

> `@Html.MailRu().Faces().Domain("mail.ru").Width(640).Height(480).Font(MailRuFacesFont.Tahoma).ShowTitle(false).BackgroundColor("aaffaa").HyperlinkColor("ffaaff").BorderColor("aaaaaa")`

> Renders Mail.ru Group (People In Group) widget.

> `@Html.MailRu().Groups().Account("mail_ru").Width(640).Height(480)`

> `@Html.MailRu().Groups().Account("mail_ru").Width(640).Height(480).BackgroundColor("aaffaa").ButtonColor("ffaaff").Subscribers(false).TextColor("aaaadd")`

**Pinterest**

You must include `<script src="@WidgetsScripts.Pinterest" type="text/javascript"></script>` directive in the end of the `<body>` tag to use below widgets.

> Renders Pinterest "Follow Me" button

> `@Html.Pinterest().FollowButton().Account("pinterest")`

> `@Html.Pinterest().FollowButton().Account("pinterest").Label("Pinterest")`

> Renders Pinterest embedded pin widget.

> `@Html.Pinterest().Pin().Id("99360735500167749")`

> Renders Pinterest Board widget with latest pins.

> `@Html.Pinterest().Board().Account("pinterest").Id("pin-pets")`

> `@Html.Pinterest().Board().Account("pinterest").Id("pin-pets").Sidebar()`

> Renders Pinterest Profile widget with user's latest pins.

> `@Html.Pinterest().Profile().Account("pinterest")`

> `@Html.Pinterest().Profile().Account("pinterest").Sidebar()`

> Renders Pinterest "Pin It" button widget.

> `@Html.Pinterest().PinItButton().Url("http://www.flickr.com/photos/kentbrew/6851755809").Image("http://farm8.staticflickr.com/7027/6851755809_df5b2051c9_z.jpg").Description("Next stop: Pinterest")`

> `@Html.Pinterest().PinItButton().Url("http://www.flickr.com/photos/kentbrew/6851755809").Image("http://farm8.staticflickr.com/7027/6851755809_df5b2051c9_z.jpg").Description("Next stop: Pinterest").CounterPosition(PinterestPinItButtonPinCountPosition.None).Size(PinterestPinItButtonSize.Large).Red().Shape(PinterestPinItButtonShape.Rectangular).Language("ja")`

**RuTube**

> Render RuTube embedded video

> `@Html.RuTube().Video().Id("6785018").Height("480").Width("640")`

**SoundCloud**

> Renders SoundCloud user's profile icon

> `@Html.SoundCloud().ProfileIcon().Account("prokhor-ozornin")`

> `@Html.SoundCloud().ProfileIcon().Account("prokhor-ozornin").BlackWhite().Size(SoundCloudProfileIconSize.Size64)`

**Surfingbird**

You must include `<script src="@WidgetsScripts.SurfingbirdSurf" type="text/javascript"></script>` directive in the end of the `<body>` tag to use below widgets.

> Render Surfingbird "Surf" button

> `@Html.Surfingbird().Surf()`

> `@Html.Surfingbird().Surf().Color(SurfingbirdSurfButtonColor.Blue).HasCounter().Label("Share").Url("http://yandex.ru").Layout(SurfingbirdSurfButtonLayout.Common)`

**Tumblr**

> Render Tumblr "Follow" button

> `@Html.Tumblr().Follow().Account("clear-words-en")`

> `@Html.Tumblr().Follow().Account("clear-words-en").ColorScheme(TumblrFollowButtonColorScheme.Dark).Type(TumblrFollowButtonType.Second)`

You must include `<script src="@WidgetsScripts.TumblrShare" type="text/javascript"></script>` directive in the end of the `<body>` tag to use below widgets.

> Render Tumblr "Share" button

> `@Html.Tumblr().Share()`

> `@Html.Tumblr().Share().ColorScheme(TumblrShareButtonColorScheme.Gray).Type(TumblrShareButtonType.Third)`

**Twitter**

You must include `WidgetsScriptsBundles.Twitter` JavaScript bundle first to use below widgets.

> Render Twitter "Tweet" button

> `@Html.Twitter().Tweet()`

> `@Html.Twitter().Tweet().HashTags("first", "second", "third").Url("http://yandex.ru").Text("Let's share it !").Via("Prokhor").OptOut()`

> Render Twitter "Follow" button

> `@Html.Twitter().Follow().Account("prokhor_ozornin")`

> `@Html.Twitter().Follow().Account("prokhor_ozornin").OptOut(false).ShowCount(false).ShowScreenName(false)`

**Vimeo**

> Render Vimeo embedded video

> `@Html.Vimeo().Video().Id("55456906").Width("640").Height("480")`

**VKontakte**

> Render VKontakte embedded video

> `@Html.Vkontakte().Video().Id("167533148").Hash("7a0cdf6ef7a69e67").User("5707198").Width("607").Height("360").HdQuality()`

You must include `<script src="@WidgetsScripts.Vkontakte" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets.

> Performs initialization of VKontakte API

> `@Html.Vkontakte().Initialize().ApiId("3816272")`

You must include `<script src="@WidgetsScripts.VKontakte" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets, as well as make a call to `@Html.Vkontakte().Initialize()` method.

> Render VKontakte comments widget

> `@Html.Vkontakte().Comments()`

> `@Html.Vkontakte().Comments().Attach(VkontakteCommentsAttach.All).Limit(VkontakteCommentsLimit.Limit15)`

> Render VKontakte community widget

> `@Html.Vkontakte().Community().Account("44545550")`

> `@Html.Vkontakte().Community().Account("44545550").Mode(VkontakteCommunityMode.News).Height(400).Width(600)`

> Render VKontakte "Like" button

> `@Html.Vkontakte().Like()`

> Render VKontakte Subscribe widget

> `@Html.Vkontakte().Subscribe().Account("5707198")`

> `@Html.Vkontakte().Subscribe().Account("5707198").OnlyButton()`

**Yandex**

> Render Yandex.Metrika analytics web counter

> `@Html.Yandex().Analytics().Account("12066574")`

> Render Yandex "Like" button

> `@Html.Yandex().Like()`

> `@Html.Yandex().Like().Title("Yandex Main Page").Text("Share").Url("http://yandex.ru").Size(YandexLikeButtonSize.Small)`

> Render Yandex embedded video

> `@Html.Yandex().Video().Id("6ea0ugstkx.2528").User("leonevskiy").Width("450").Height("253")`

You must include `<script src="@WidgetsScripts.YandexShare" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets.

> Render Yandex "Share" button

> `@Html.Yandex().Share()`

> `@Html.Yandex().Share().Services("facebook").Language("en")`

> Render Yandex.Money payment button

> `@Html.Yandex().MoneyButton().Account("41001577953208").Sum(15.5).Description("Test Payment")`

> `@Html.Yandex().MoneyButton().Account("41001577953208").Sum(15.5).Description("Test Payment").Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Buy).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).PayerAddress().PayerEmail().PayerFullName().PayerPhone()`

> Render Yandex.Money donation form

> `@Html.Yandex().MoneyDonateForm().Account("41001577953208").Description("Test Donation")`

> `@Html.Yandex().MoneyDonateForm().Account("41001577953208").Description("Test Donation").ShowDescription().Sum(15.5).Cards().ProjectName("Yandex").ProjectSite("http://yandex.ru").Text(YandexMoneyDonateFormText.Give).PayerPhone().PayerFullName().PayerComment().PayerEmail()`

> Render Yandex.Money payment form

> `@Html.Yandex().MoneyPaymentForm().Account("41001577953208").Description("Test Payment")`

> `@Html.Yandex().MoneyPaymentForm().Account("41001577953208").Description("Test Payment").Sum(15.5).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).PayerComment().PayerEmail().PayerFullName().PayerAddress().PayerPhone().PayerPurpose()`

**YouTube**

> Render YouTube embedded video

> `@Html.YouTube().Video().Id("eYJSlHiXegI").Width("100%").Height("480")`

**VideoJS**

You must include `<script src="@WidgetsScripts.VideoJS" type="text/javascript"></script>` and `<link href="@WidgetsStyles.VideoJS" rel="stylesheet" />` directives in the `<head>` tag to use below widgets.

> Render VideoJS media player

> `@Html.VideoJS().Player().Width("640").Height("480").Videos(new MediaSource("http://vjs.zencdn.net/v/oceans.mp4", VideoContentTypes.MP4), new MediaSource("http://vjs.zencdn.net/v/oceans.webm", VideoContentTypes.WebM)).HtmlBody(@"<track kind=""captions"" src=""http://www.videojs.com/vtt/captions.vtt"" srclang=""en"" label=""English""></track>")`

_Note:_ Instead of using different separate JavaScript bundles with `@Scripts.Render` directive for separate social tags, you can use all-in-one module bundle, called "widgets" once :

`<head>`

  `@Scripts.Render(WidgetsScriptsBundles.Widgets)`

`</head>`