using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Analytics(IYandexHtmlHelper, Action{IYandexAnalyticsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Analytics_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Analytics(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Analytics(null));

      Assert.True(new YandexHtmlHelper().Analytics(x => { }) == new YandexHtmlHelper().Analytics().ToHtmlString());
      Assert.True(new YandexHtmlHelper().Analytics(x => x.Account("account")) == new YandexHtmlHelper().Analytics().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Like(IYandexHtmlHelper, Action{IYandexLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Like(null));

      Assert.True(new YandexHtmlHelper().Like(x => { }) == new YandexHtmlHelper().Like().ToHtmlString());
      Assert.True(new YandexHtmlHelper().Like(x => x.Url("url")) == new YandexHtmlHelper().Like().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Share(IYandexHtmlHelper, Action{IYandexSharePanelWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Share(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Share(null));

      Assert.True(new YandexHtmlHelper().Share(x => { }) == new YandexHtmlHelper().Share().ToHtmlString());
      Assert.True(new YandexHtmlHelper().Share(x => x.Layout(YandexSharePanelLayout.Button)) == new YandexHtmlHelper().Share().Layout(YandexSharePanelLayout.Button).ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Video(IYandexHtmlHelper, Action{IYandexVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Video(null));

      Assert.True(new YandexHtmlHelper().Video(x => { }) == new YandexHtmlHelper().Video().ToHtmlString());
      Assert.True(new YandexHtmlHelper().Video(x => x.Id("id").Width("width").Height("height").User("user")) == new YandexHtmlHelper().Video().Id("id").Width("width").Height("height").User("user").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.VideoLink(IYandexHtmlHelper, Action{IYandexVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().VideoLink(null));

      Assert.True(new YandexHtmlHelper().VideoLink(x => { }) == new YandexHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new YandexHtmlHelper().VideoLink(x => x.Id("id").User("user")) == new YandexHtmlHelper().VideoLink().Id("id").User("user").ToHtmlString());
    }
  }
}