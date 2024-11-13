namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ICackleWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="ICackleWidgetsCreator"/>
public static class ICackleWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Cackle comments widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ICackleWidgetsCreator.Comments()"/>
  public static string Comments(this ICackleWidgetsCreator creator, Action<ICackleCommentsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Comments();
      
    builder(widget);

    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Cackle comments count widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ICackleHtmlHelper.CommentsCount()"/>
  public static string CommentsCount(this ICackleWidgetsCreator creator, Action<ICackleCommentsCountWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.CommentsCount();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Cackle latest comments widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ICackleHtmlHelper.LatestComments()"/>
  public static string LatestComments(this ICackleWidgetsCreator creator, Action<ICackleLatestCommentsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LatestComments();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Cackle OAuth login widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ICackleHtmlHelper.Login()"/>
  public static string Login(this ICackleWidgetsCreator creator, Action<ICackleLoginWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));
      
    var widget = creator.Login();
      
    builder(widget);
      
    return widget.ToHtml();
  }
}