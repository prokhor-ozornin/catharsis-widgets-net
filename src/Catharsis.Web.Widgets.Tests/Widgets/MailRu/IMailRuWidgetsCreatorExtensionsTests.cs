using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IMailRuWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuWidgetsCreatorExtensions.Faces(IMailRuWidgetsCreator, Action{IMailRuFacesWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IMailRuWidgetsCreatorExtensions.Faces(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new MailRuWidgetsCreator().Faces(null));

    Assert.Equal(new MailRuWidgetsCreator().Faces().ToHtml(), new MailRuWidgetsCreator().Faces(_ => { }));
    Assert.Equal(new MailRuWidgetsCreator().Faces().Domain("domain").ToHtml(), new MailRuWidgetsCreator().Faces(x => x.Domain("domain")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuWidgetsCreatorExtensions.Groups(IMailRuWidgetsCreator, Action{IMailRuGroupsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Groups_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IMailRuWidgetsCreatorExtensions.Groups(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new MailRuWidgetsCreator().Groups(null));

    Assert.Equal(new MailRuWidgetsCreator().Groups().ToHtml(), new MailRuWidgetsCreator().Groups(_ => { }));
    Assert.Equal(new MailRuWidgetsCreator().Groups().Account("account").ToHtml(), new MailRuWidgetsCreator().Groups(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuWidgetsCreatorExtensions.Icq(IMailRuWidgetsCreator, Action{IMailRuIcqWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Icq_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IMailRuWidgetsCreatorExtensions.Icq(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new MailRuWidgetsCreator().Icq(null));

    Assert.Equal(new MailRuWidgetsCreator().Icq().ToHtml(), new MailRuWidgetsCreator().Icq(_ => { }));
    Assert.Equal(new MailRuWidgetsCreator().Icq().Account("account").ToHtml(), new MailRuWidgetsCreator().Icq(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuWidgetsCreatorExtensions.LikeButton(IMailRuWidgetsCreator, Action{IMailRuLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IMailRuWidgetsCreatorExtensions.LikeButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new MailRuWidgetsCreator().LikeButton(null));

    Assert.Equal(new MailRuWidgetsCreator().LikeButton().ToHtml(), new MailRuWidgetsCreator().LikeButton(_ => { }));
    Assert.Equal(new MailRuWidgetsCreator().LikeButton().Type(MailRuLikeButtonType.All).ToHtml(), new MailRuWidgetsCreator().LikeButton(x => x.Type(MailRuLikeButtonType.All)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuWidgetsCreatorExtensions.Video(IMailRuWidgetsCreator, Action{IMailRuVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IMailRuWidgetsCreatorExtensions.Video(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new MailRuWidgetsCreator().Video(null));

    Assert.Equal(new MailRuWidgetsCreator().Video().ToHtml(), new MailRuWidgetsCreator().Video(_ => { }));
    Assert.Equal(new MailRuWidgetsCreator().Video().ToHtml(), new MailRuWidgetsCreator().Video(x => x.Id("id")));
  }
}