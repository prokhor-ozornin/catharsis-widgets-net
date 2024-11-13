namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ILiveJournalWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="ILiveJournalWidgetsCreator"/>
public static class ILiveJournalWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new LiveJournal "Like" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ILiveJournalWidgetsCreator.LikeButton()"/>
  public static string LikeButton(this ILiveJournalWidgetsCreator creator, Action<ILiveJournalLikeButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LikeButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new LiveJournal "Repost" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ILiveJournalWidgetsCreator.RepostButton()"/>
  public static string RepostButton(this ILiveJournalWidgetsCreator creator, Action<ILiveJournalRepostButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.RepostButton();

    builder(widget);
      
    return widget.ToHtml();
  }
}