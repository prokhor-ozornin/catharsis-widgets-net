using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="HtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="HtmlHelper"/>
  public static class HtmlHelperExtensions
  {
    private static ICackleHtmlHelper cackle;
    private static IDisqusHtmlHelper disqus;
    private static IFacebookHtmlHelper facebook;
    private static IGoogleHtmlHelper google;
    private static IIntenseDebateHtmlHelper intensedebate;
    private static IMailRuHtmlHelper mailru;
    private static IRuTubeHtmlHelper rutube;
    //private static IShare42HtmlHelper share42;
    private static ISurfingbirdHtmlHelper surfingbird;
    private static ITumblrHtmlHelper tumblr;
    private static ITwitterHtmlHelper twitter;
    private static IVideoJSHtmlHelper videoJS;
    private static IVimeoHtmlHelper vimeo;
    private static IVkontakteHtmlHelper vkontakte;
    private static IYandexHtmlHelper yandex;
    private static IYouTubeHtmlHelper youtube;

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Cackle widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static ICackleHtmlHelper Cackle(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return cackle ?? (cackle = new CackleHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Disqus widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IDisqusHtmlHelper Disqus(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return disqus ?? (disqus = new DisqusHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Facebook widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IFacebookHtmlHelper Facebook(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return facebook ?? (facebook = new FacebookHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Google widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IGoogleHtmlHelper Google(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return google ?? (google = new GoogleHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes inline image widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widget instance.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IInlineImageWidget InlineImage(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return new InlineImageWidget();
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of IntenseDebate widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IIntenseDebateHtmlHelper IntenseDebate(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return intensedebate ?? (intensedebate = new IntenseDebateHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Mail.ru widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IMailRuHtmlHelper MailRu(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return mailru ?? (mailru = new MailRuHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of RuTube widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IRuTubeHtmlHelper RuTube(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return rutube ?? (rutube = new RuTubeHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Share42 widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    /*public static IShare42HtmlHelper Share42(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return share42 ?? (share42 = new Share42HtmlHelper());
    }*/

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Surfingbird widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static ISurfingbirdHtmlHelper Surfingbird(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return surfingbird ?? (surfingbird = new SurfingbirdHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Tumblr widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static ITumblrHtmlHelper Tumblr(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return tumblr ?? (tumblr = new TumblrHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Twitter widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static ITwitterHtmlHelper Twitter(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return twitter ?? (twitter = new TwitterHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of VideoJS widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IVideoJSHtmlHelper VideoJS(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return videoJS ?? (videoJS = new VideoJSHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Vimeo widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IVimeoHtmlHelper Vimeo(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return vimeo ?? (vimeo = new VimeoHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Vkontakte widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IVkontakteHtmlHelper Vkontakte(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return vkontakte ?? (vkontakte = new VkontakteHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of Yandex widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IYandexHtmlHelper Yandex(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return yandex ?? (yandex = new YandexHtmlHelper());
    }

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of YouTube widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IYouTubeHtmlHelper YouTube(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return youtube ?? (youtube = new YouTubeHtmlHelper());
    }
  }
}