namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuHtmlHelper"/>
public class MailRuHtmlHelper : IMailRuHtmlHelper
{
  /// <inheritdoc cref="IMailRuHtmlHelper.Faces()"/>
  public IMailRuFacesWidget Faces() => new MailRuFacesWidget();

  /// <inheritdoc cref="IMailRuHtmlHelper.Groups()"/>
  public IMailRuGroupsWidget Groups() => new MailRuGroupsWidget();

  /// <inheritdoc cref="IMailRuHtmlHelper.Icq()"/>
  public IMailRuIcqWidget Icq() => new MailRuIcqWidget();

  /// <inheritdoc cref="IMailRuHtmlHelper.LikeButton()"/>
  public IMailRuLikeButtonWidget LikeButton() => new MailRuLikeButtonWidget();

  /// <inheritdoc cref="IMailRuHtmlHelper.Video()"/>
  public IMailRuVideoWidget Video() => new MailRuVideoWidget();
}