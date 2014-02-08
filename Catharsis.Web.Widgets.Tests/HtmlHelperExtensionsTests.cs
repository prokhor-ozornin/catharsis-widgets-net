using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class HtmlHelperExtensionsTests
  {
    private static readonly HtmlHelper html = new HtmlHelper(new ViewContext(), new ViewPage());

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Cackle(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cackle_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Cackle(null));

      Assert.True(html.Cackle() != null);
      Assert.True(ReferenceEquals(html.Cackle(), html.Cackle()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Disqus(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Disqus_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Disqus(null));

      Assert.True(html.Disqus() != null);
      Assert.True(ReferenceEquals(html.Disqus(), html.Disqus()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Facebook(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Facebook_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Facebook(null));

      Assert.True(html.Facebook() != null);
      Assert.True(ReferenceEquals(html.Facebook(), html.Facebook()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Google(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Google_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Google(null));

      Assert.True(html.Google() != null);
      Assert.True(ReferenceEquals(html.Google(), html.Google()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.InlineImage(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void InlineImage_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.InlineImage(null));

      Assert.True(html.InlineImage() != null);
      Assert.False(ReferenceEquals(html.InlineImage(), html.InlineImage()));
      Assert.True(html.InlineImage().ToString() == html.InlineImage().ToString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.IntenseDebate(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void IntenseDebate_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.IntenseDebate(null));

      Assert.True(html.IntenseDebate() != null);
      Assert.True(ReferenceEquals(html.IntenseDebate(), html.IntenseDebate()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.MailRu(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void MailRu_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.MailRu(null));

      Assert.True(html.MailRu() != null);
      Assert.True(ReferenceEquals(html.MailRu(), html.MailRu()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.RuTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void RuTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.RuTube(null));

      Assert.True(html.RuTube() != null);
      Assert.True(ReferenceEquals(html.RuTube(), html.RuTube()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Share42(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Share42_Method()
    {
      /*Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Share42(null));

      Assert.True(html.Share42() != null);
      Assert.True(ReferenceEquals(html.Share42(), html.Share42()));*/
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Surfingbird(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Surfingbird_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Surfingbird(null));

      Assert.True(html.Surfingbird() != null);
      Assert.True(ReferenceEquals(html.Surfingbird(), html.Surfingbird()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Tumblr(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Tumblr_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Tumblr(null));

      Assert.True(html.Tumblr() != null);
      Assert.True(ReferenceEquals(html.Tumblr(), html.Tumblr()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Twitter(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Twitter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Twitter(null));

      Assert.True(html.Twitter() != null);
      Assert.True(ReferenceEquals(html.Twitter(), html.Twitter()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vimeo(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vimeo_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vimeo(null));

      Assert.True(html.Vimeo() != null);
      Assert.True(ReferenceEquals(html.Vimeo(), html.Vimeo()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vkontakte(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vkontakte_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vkontakte(null));

      Assert.True(html.Vkontakte() != null);
      Assert.True(ReferenceEquals(html.Vkontakte(), html.Vkontakte()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Yandex(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Yandex_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Yandex(null));

      Assert.True(html.Yandex() != null);
      Assert.True(ReferenceEquals(html.Yandex(), html.Yandex()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.YouTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void YouTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.YouTube(null));

      Assert.True(html.YouTube() != null);
      Assert.True(ReferenceEquals(html.YouTube(), html.YouTube()));
    }
  }
}