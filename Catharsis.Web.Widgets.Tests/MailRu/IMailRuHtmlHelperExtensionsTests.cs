using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IMailRuHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IMailRuHtmlHelperExtensionsTests
  {
    /*/// <summary>
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Faces(IMailRuHtmlHelper, Action{IMailRuFacesWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Faces(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Faces(null));

      Assert.Equal(new MailRuHtmlHelper().Faces().ToHtmlString(), new MailRuHtmlHelper().Faces(x => { }));

      throw new NotImplementedException();
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

      throw new NotImplementedException();
    }*/

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
    ///   <para>Performs testing of <see cref="IMailRuHtmlHelperExtensions.Like(IMailRuHtmlHelper, Action{IMailRuLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new MailRuHtmlHelper().Like(null));

      Assert.Equal(new MailRuHtmlHelper().Like().ToHtmlString(), new MailRuHtmlHelper().Like(x => { }));
      Assert.Equal(new MailRuHtmlHelper().Like().Type(MailRuLikeButtonType.All).ToHtmlString(), new MailRuHtmlHelper().Like(x => x.Type(MailRuLikeButtonType.All)));
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