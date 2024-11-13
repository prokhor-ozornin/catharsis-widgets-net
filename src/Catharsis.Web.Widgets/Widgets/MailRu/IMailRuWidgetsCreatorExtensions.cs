namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IMailRuWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IMailRuWidgetsCreator"/>
public static class IMailRuWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Mail.ru Faces (People On Site) widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuWidgetCreator.Faces()"/>
  public static string Faces(this IMailRuWidgetsCreator creator, Action<IMailRuFacesWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));
      
    var widget = creator.Faces();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Mail.ru Group (People In Group) widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuWidgetCreator.Groups()"/>
  public static string Groups(this IMailRuWidgetsCreator creator, Action<IMailRuGroupsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Groups();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Mail.ru ICQ On-Site widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuWidgetCreator.Icq()"/>
  public static string Icq(this IMailRuWidgetsCreator creator, Action<IMailRuIcqWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Icq();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Mail.ru "Like" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuWidgetsCreator.LikeButton()"/>
  public static string LikeButton(this IMailRuWidgetsCreator creator, Action<IMailRuLikeButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LikeButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Mail.ru embedded video widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuWidgetsCreator.Video()"/>
  public static string Video(this IMailRuWidgetsCreator creator, Action<IMailRuVideoWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Video();

    builder(widget);
      
    return widget.ToHtml();
  }
}