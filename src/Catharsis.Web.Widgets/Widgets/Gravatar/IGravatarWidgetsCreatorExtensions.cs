namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGravatarWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IGravatarWidgetsCreator"/>
public static class IGravatarWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Gravatar's avatar URL widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGravatarWidgetsCreator.ImageUrl()"/>
  public static string ImageUrl(this IGravatarWidgetsCreator creator, Action<IGravatarImageUrlWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.ImageUrl();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Gravatar's user profile URL widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGravatarWidgetsCreator.ProfileUrl()"/>
  public static string ProfileUrl(this IGravatarWidgetsCreator creator, Action<IGravatarProfileUrlWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.ProfileUrl();

    builder(widget);
    
    return widget.ToHtml();
  }
}