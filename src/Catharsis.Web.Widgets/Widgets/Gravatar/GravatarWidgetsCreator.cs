namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarWidgetsCreator"/>
public class GravatarWidgetsCreator : IGravatarWidgetsCreator
{
  /// <inheritdoc cref="IGravatarWidgetsCreator.ImageUrl()"/>
  public virtual IGravatarImageUrlWidget ImageUrl() => new GravatarImageUrlWidget();

  /// <inheritdoc cref="IGravatarWidgetsCreator.ProfileUrl()"/>
  public virtual IGravatarProfileUrlWidget ProfileUrl() => new GravatarProfileUrlWidget();
}