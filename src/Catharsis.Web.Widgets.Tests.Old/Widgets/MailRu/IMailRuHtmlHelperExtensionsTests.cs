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
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Faces(IMailRuHtmlHelper, Action{IMailRuFacesWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Faces(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Faces(null));

      Assert.Equal(new MailRuHtmlHelper().Faces().ToHtmlString(), new MailRuHtmlHelper().Faces(x => { }));
      Assert.Equal(new MailRuHtmlHelper().Faces().Domain("domain").ToHtmlString(), new MailRuHtmlHelper().Faces(x => x.Domain("domain")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Groups(IMailRuHtmlHelper, Action{IMailRuGroupsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Groups_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Groups(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Groups(null));

      Assert.Equal(new MailRuHtmlHelper().Groups().ToHtmlString(), new MailRuHtmlHelper().Groups(x => { }));
      Assert.Equal(new MailRuHtmlHelper().Groups().Account("account").ToHtmlString(), new MailRuHtmlHelper().Groups(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Icq(IMailRuHtmlHelper, Action{IMailRuIcqWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Icq_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Icq(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Icq(null));

      Assert.Equal(new MailRuHtmlHelper().Icq().ToHtmlString(), new MailRuHtmlHelper().Icq(x => { }));
      Assert.Equal(new MailRuHtmlHelper().Icq().Account("account").ToHtmlString(), new MailRuHtmlHelper().Icq(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.LikeButton(IMailRuHtmlHelper, Action{IMailRuLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LikeButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.LikeButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().LikeButton(null));

      Assert.Equal(new MailRuHtmlHelper().LikeButton().ToHtmlString(), new MailRuHtmlHelper().LikeButton(x => { }));
      Assert.Equal(new MailRuHtmlHelper().LikeButton().Type(MailRuLikeButtonType.All).ToHtmlString(), new MailRuHtmlHelper().LikeButton(x => x.Type(MailRuLikeButtonType.All)));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Video(IMailRuHtmlHelper, Action{IMailRuVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Video(null));

      Assert.Equal(new MailRuHtmlHelper().Video().ToHtmlString(), new MailRuHtmlHelper().Video(x => { }));
      Assert.Equal(new MailRuHtmlHelper().Video().ToHtmlString(), new MailRuHtmlHelper().Video(x => x.Id("id")));
    }
  }
}