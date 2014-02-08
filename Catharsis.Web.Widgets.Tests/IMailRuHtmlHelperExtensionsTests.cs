using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IMailRuHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IMailRuHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Icq(IMailRuHtmlHelper, Action{IMailRuIcqWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Icq_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Icq(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Icq(null));

      Assert.True(new MailRuHtmlHelper().Icq(x => { }) == new MailRuHtmlHelper().Icq().ToHtmlString());
      Assert.True(new MailRuHtmlHelper().Icq(x => x.Account("account")) == new MailRuHtmlHelper().Icq().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Like(IMailRuHtmlHelper, Action{IMailRuLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Like(null));

      Assert.True(new MailRuHtmlHelper().Like(x => { }) == new MailRuHtmlHelper().Like().ToHtmlString());
      Assert.True(new MailRuHtmlHelper().Like(x => x.Type(MailRuLikeButtonType.All)) == new MailRuHtmlHelper().Like().Type(MailRuLikeButtonType.All).ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Video(IMailRuHtmlHelper, Action{IMailRuVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Video(null));

      Assert.True(new MailRuHtmlHelper().Video(x => { }) == new MailRuHtmlHelper().Video().ToHtmlString());
      Assert.True(new MailRuHtmlHelper().Video(x => x.Id("id")) == new MailRuHtmlHelper().Video().Id("id").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.VideoLink(IMailRuHtmlHelper, Action{IMailRuVideoLinkWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void VideoLink_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.VideoLink(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().VideoLink(null));

      Assert.True(new MailRuHtmlHelper().VideoLink(x => { }) == new MailRuHtmlHelper().VideoLink().ToHtmlString());
      Assert.True(new MailRuHtmlHelper().VideoLink(x => x.Id("id")) == new MailRuHtmlHelper().VideoLink().Id("id").ToHtmlString());
    }
  }
}