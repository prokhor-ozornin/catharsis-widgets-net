**Catharsis.NET.Web.Widgets** is ASP.NET MVC library, which provides useful social media widgets to include on web pages of your site. 

This library is basically a port of [Grails 2](http://grails.org) [Catharsis.Grails.Widgets](https://github.com/prokhor-ozornin/Catharsis.Grails.Widgets) library to ASP.NET MVC web framework.

Web widgets are implemented as C# POCO objects that implement `System.Web.IHtmlString` and provide convenient fluent interface to work with. Extension methods for `System.Web.Mvc.HtmlHelper` for easiness of rendering are also provided as well.

As of the latest version, the following areas are covered :

1. [Cackle](http://cackle.me)
Comments and OAuth Login widgets

2. [Disqus](http://disqus.com)
Comments widget

3. [Facebook](http://facebook.com)
"Like" button, Embedded post, Embedded video, Video hyperlink

4. [Google](http://google.com)
Google Analytics, Google + 1 button

5. [IntenseDebate](http://intensedebate.com)
Comments widget, comments count hyperlink

6. [Mail.ru](http://mail.ru)
ICQ On-Site widget, "Like" button (mail.ru/odnoklassniki.ru), Embedded video, Video hyperlink

7. [RuTube](http://rutube.ru)
Embedded video, Video hyperlink

8. [Share42](http://share42.com)
Social buttons widget

9. [Surfingbird](http://surfingbird.com)
"Like" button

10. [Tumblr](http://tumblr.com)
"Follow" button, "Share" button

11. [Twitter](https://twitter.com)
"Follow" button, "Tweet" button

12. [Vimeo](https://vimeo.com)
Embedded video, Video hyperlink

13. [VKontakte](http://vk.com)
Comments widget, Community widget, "Like" button, Subscribe widget, Embedded video, Video hyperlink

14. [Yandex](http://yandex.ru)
Yandex Analytics, "Ya" button, "Share" button, Embedded video, Video hyperlink

15. [YouTube](http://youtube.com)
Embedded video, Video hyperlink


The list of social tags is ever-growing, and new ones can be included upon request fast.

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

> Render Facebook video hyperlink

> `@Html.Facebook().VideoLink().Id("10203121281421359").HtmlBody("Watch a Facebook video !")`

> Performs Facebook JavaScript API initialization

> `@Html.Facebook().Initialize().AppId("1437917246425293")`

You must include call to `@Html.Facebook().Initialize()` helper first to use below widgets.

> Render Facebook "Like" button

> `@Html.Facebook().Like().Url("http://yandex.ru")`

> `@Html.Facebook().Like().Url("http://yandex.ru").Layout(FacebookLikeButtonLayout.BoxCount).ShowFaces().Verb(FacebookLikeButtonVerb.Recommend)`

> Render Facebook embedded post

> `@Html.Facebook().Post().Url("https://www.facebook.com/prokhor.ozornin/posts/10203109769053557").Width(640)`

**Google**

> Render Google Analytics tracking code

> `@Html.Google().Analytics().Domain("v-svete-snov.ru").Account("UA-27123759-16")`

You must include `WidgetsScriptsBundles.Google` JavaScript bundle first to use below widgets.

> Render Google "+1" button

> `@Html.Google().PlusOne()`

> `@Html.Google().PlusOne().Url("http://yandex.ru").Alignment(GooglePlusOneButtonAlignment.Right).Size(GooglePlusOneButtonSize.Tall).Annotation(GooglePlusOneButtonAnnotation.Inline).Recommendations(false)`

**IntenseDebate**

> Render IntenseDebate comments widget

> `@Html.IntenseDebate().Comments().Account("a639ec3507d53023d4f213666651b6c2")`

> Render IntenseDebate hyperlink with comments count

> `@Html.IntenseDebate().Link().Account("a639ec3507d53023d4f213666651b6c2")`

**Mail.ru**

> Render ICQ On-Site widget

> `@Html.MailRu().Icq()`

> `@Html.MailRu().Icq().Account("12345678").Language("en")`

> Render Mail.ru embedded video

> `@Html.MailRu().Video().Id("i.v.sosnin62/3023/3027.html").Height("480").Width("640")`

> Render Mail.ru video hyperlink

> `@Html.MailRu().VideoLink().Id("i.v.sosnin62/3023/3027.html").HtmlBody("Watch Mail.ru video !")`

You must include `<script src="@WidgetsScripts.MailRuLike" type="text/javascript"></script>` directive in the end of the `<body>` tag to use below widgets.

> Render Mail.ru + Odnoklassniki.ru "Like" buttons pair

> `@Html.MailRu().Like()`

> `@Html.MailRu().Like().Layout(MailRuLikeButtonLayout.Second).HasText(false).CounterPosition(MailRuLikeButtonCounterPosition.Upper).Size(30)`

**RuTube**

> Render RuTube embedded video

> `@Html.RuTube().Video().Id("6785018").Height("480").Width("640")`

> Render RuTube video hyperlink

> `@Html.RuTube().VideoLink().Id("4c5fe858f0013ea73188a3534af12f2b").HtmlBody("Watch RuTube video !")`

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

> Render Vimeo video hyperlink

> `@Html.Vimeo().VideoLink().Id("55456906").HtmlBody("Watch Vimeo video!")`

**VKontakte**

> Render VKontakte embedded video

> `@Html.Vkontakte().Video().Id("167533148").Hash("7a0cdf6ef7a69e67").User("5707198").Width("607").Height("360").HdQuality()`

> Render VKontakte video hyperlink

> `@Html.Vkontakte().VideoLink().Id("167533148").User("5707198").HtmlBody("Watch VKontakte video !")`

You must include `<script src="@WidgetsScripts.Vkontakte" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets.

> Performs initialization of VKontakte API

> `@Html.Vkontakte().Initialize().ApiId("3816272")`

You must include `<script src="@WidgetsScripts.Vkontakte" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets, as well as make a call to `@Html.Vkontakte().Initialize()` method.

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

> Render Yandex video hyperlink

> `@Html.Yandex().VideoLink().Id("1").User("leonevskiy").HtmlBody("Watch Yandex video!")`

You must include `<script src="@WidgetsScripts.YandexShare" type="text/javascript"></script>` directive in the `<head>` tag to use below widgets.

> Render Yandex "Share" button

> `@Html.Yandex().Share()`

> `@Html.Yandex().Share().Services("facebook").Language("en")`

**YouTube**

> Render YouTube embedded video

> `@Html.YouTube().Video().Id("eYJSlHiXegI").Width("100%").Height("480")`

> Render YouTube video hyperlink

> `@Html.YouTube().VideoLink().Id("eYJSlHiXegI").HtmlBody("Watch YouTube video!")`

_Note:_ Instead of using different separate JavaScript bundles with `@Scripts.Render` directive for separate social tags, you can use all-in-one module bundle, called "widgets" once :

`<head>`

  `@Scripts.Render(WidgetsScriptsBundles.Widgets)`

`</head>`

