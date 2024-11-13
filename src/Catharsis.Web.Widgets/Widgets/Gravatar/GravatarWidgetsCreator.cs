namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarWidgetsCreator"/>
public class GravatarWidgetsCreator : IGravatarWidgetsCreator
{
  /// <inheritdoc cref="IGravatarWidgetsCreator.ImageUrl()"/>
  public IGravatarImageUrlWidget ImageUrl() => new GravatarImageUrlWidget();

  /// <inheritdoc cref="IGravatarWidgetsCreator.ProfileUrl()"/>
  public IGravatarProfileUrlWidget ProfileUrl() => new GravatarProfileUrlWidget();
}