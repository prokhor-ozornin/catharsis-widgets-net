namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuWidgetsCreator"/>
public class MailRuWidgetsCreator : IMailRuWidgetsCreator
{
  /// <inheritdoc cref="IMailRuWidgetsCreator.Faces()"/>
  public virtual IMailRuFacesWidget Faces() => new MailRuFacesWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Groups()"/>
  public virtual IMailRuGroupsWidget Groups() => new MailRuGroupsWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Icq()"/>
  public virtual IMailRuIcqWidget Icq() => new MailRuIcqWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.LikeButton()"/>
  public virtual IMailRuLikeButtonWidget LikeButton() => new MailRuLikeButtonWidget();

  /// <inheritdoc cref="IMailRuWidgetsCreator.Video()"/>
  public virtual IMailRuVideoWidget Video() => new MailRuVideoWidget();
}