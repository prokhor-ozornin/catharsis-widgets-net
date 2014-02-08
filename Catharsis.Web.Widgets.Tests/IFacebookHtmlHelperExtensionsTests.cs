using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Initialize(IFacebookHtmlHelper, Action{IFacebookInitWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Initialize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Initialize(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Initialize(null));

      Assert.True(new FacebookHtmlHelper().Initialize(x => { }) == new FacebookHtmlHelper().Initialize().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Initialize(x => x.AppId("appId")) == new FacebookHtmlHelper().Initialize().AppId("appId").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Post(IFacebookHtmlHelper, Action{IFacebookPostWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Post_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Post(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Post(null));

      Assert.True(new FacebookHtmlHelper().Post(x => { }) == new FacebookHtmlHelper().Post().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Post(x => x.Url("url")) == new FacebookHtmlHelper().Post().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Like(IFacebookHtmlHelper, Action{IFacebookLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Like(null));

      Assert.True(new FacebookHtmlHelper().Like(x => { }) == new FacebookHtmlHelper().Like().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Like(x => x.Url("url")) == new FacebookHtmlHelper().Like().Url("url").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.Video(IFacebookHtmlHelper, Action{IFacebookVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().Video(null));

      Assert.True(new FacebookHtmlHelper().Video(x => { }) == new FacebookHtmlHelper().Video().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().Video(x => x.Id("id")) == new FacebookHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookHtmlHelperExtensions.VideoLink(IFacebookHtmlHelper, Action{IFacebookVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new FacebookHtmlHelper().VideoLink(null));

      Assert.True(new FacebookHtmlHelper().VideoLink(x => { }) == new FacebookHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new FacebookHtmlHelper().VideoLink(x => x.Id("id")) == new FacebookHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}