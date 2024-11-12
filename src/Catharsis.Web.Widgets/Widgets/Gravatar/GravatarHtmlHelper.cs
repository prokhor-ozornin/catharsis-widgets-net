namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarHtmlHelper"/>
public class GravatarHtmlHelper : IGravatarHtmlHelper
{
  /// <inheritdoc cref="IGravatarHtmlHelper.ImageUrl()"/>
  public IGravatarImageUrlWidget ImageUrl() => new GravatarImageUrlWidget();

  /// <inheritdoc cref="IGravatarHtmlHelper.ProfileUrl()"/>
  public IGravatarProfileUrlWidget ProfileUrl() => new GravatarProfileUrlWidget();
}