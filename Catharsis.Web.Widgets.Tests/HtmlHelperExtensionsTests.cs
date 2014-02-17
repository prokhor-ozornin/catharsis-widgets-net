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

      Assert.NotNull(html.Cackle());
      Assert.True(ReferenceEquals(html.Cackle(), html.Cackle()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Disqus(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Disqus_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Disqus(null));

      Assert.NotNull(html.Disqus());
      Assert.True(ReferenceEquals(html.Disqus(), html.Disqus()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Facebook(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Facebook_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Facebook(null));

      Assert.NotNull(html.Facebook());
      Assert.True(ReferenceEquals(html.Facebook(), html.Facebook()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Google(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Google_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Google(null));

      Assert.NotNull(html.Google());
      Assert.True(ReferenceEquals(html.Google(), html.Google()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.InlineImage(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void InlineImage_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.InlineImage(null));

      Assert.NotNull(html.InlineImage());
      Assert.False(ReferenceEquals(html.InlineImage(), html.InlineImage()));
      Assert.Equal(html.InlineImage().ToString(), html.InlineImage().ToString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.IntenseDebate(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void IntenseDebate_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.IntenseDebate(null));

      Assert.NotNull(html.IntenseDebate());
      Assert.True(ReferenceEquals(html.IntenseDebate(), html.IntenseDebate()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.MailRu(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void MailRu_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.MailRu(null));

      Assert.NotNull(html.MailRu());
      Assert.True(ReferenceEquals(html.MailRu(), html.MailRu()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.RuTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void RuTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.RuTube(null));

      Assert.NotNull(html.RuTube());
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

      Assert.NotNull(html.Surfingbird());
      Assert.True(ReferenceEquals(html.Surfingbird(), html.Surfingbird()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Tumblr(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Tumblr_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Tumblr(null));

      Assert.NotNull(html.Tumblr());
      Assert.True(ReferenceEquals(html.Tumblr(), html.Tumblr()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Twitter(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Twitter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Twitter(null));

      Assert.NotNull(html.Twitter());
      Assert.True(ReferenceEquals(html.Twitter(), html.Twitter()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.VideoJS(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoJS_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.VideoJS(null));

      Assert.NotNull(html.VideoJS());
      Assert.True(ReferenceEquals(html.VideoJS(), html.VideoJS()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vimeo(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vimeo_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vimeo(null));

      Assert.NotNull(html.Vimeo());
      Assert.True(ReferenceEquals(html.Vimeo(), html.Vimeo()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Vkontakte(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vkontakte_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Vkontakte(null));

      Assert.NotNull(html.Vkontakte());
      Assert.True(ReferenceEquals(html.Vkontakte(), html.Vkontakte()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.Yandex(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void Yandex_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.Yandex(null));

      Assert.NotNull(html.Yandex());
      Assert.True(ReferenceEquals(html.Yandex(), html.Yandex()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HtmlHelperExtensions.YouTube(HtmlHelper)"/> method.</para>
    /// </summary>
    [Fact]
    public void YouTube_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.YouTube(null));

      Assert.NotNull(html.YouTube());
      Assert.True(ReferenceEquals(html.YouTube(), html.YouTube()));
    }
  }
}