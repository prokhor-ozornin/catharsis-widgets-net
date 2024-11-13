namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuWidgetsCreator"/>
public class MailRuWidgetsCreator : IMailRuWidgetsCreator
{
  /// <inheritdoc cref="IMailRuWidgetsCreator.Faces()"/>
  public IMailRuFacesWidget Faces() => new MailRuFacesWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Groups()"/>
  public IMailRuGroupsWidget Groups() => new MailRuGroupsWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Icq()"/>
  public IMailRuIcqWidget Icq() => new MailRuIcqWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.LikeButton()"/>
  public IMailRuLikeButtonWidget LikeButton() => new MailRuLikeButtonWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Video()"/>
  public IMailRuVideoWidget Video() => new MailRuVideoWidget();
}