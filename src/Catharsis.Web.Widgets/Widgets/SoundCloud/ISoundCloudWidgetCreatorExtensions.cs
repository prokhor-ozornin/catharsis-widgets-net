namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ISoundCloudWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="ISoundCloudWidgetCreator"/>
public static class ISoundCloudWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new SoundCloud profile icon widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ISoundCloudWidgetCreator.ProfileIcon()"/>
  public static string ProfileIcon(this ISoundCloudWidgetCreator creator, Action<ISoundCloudProfileIconWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.ProfileIcon();

    builder(widget);
      
    return widget.ToHtml();
  }
}