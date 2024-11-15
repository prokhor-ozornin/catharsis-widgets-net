namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new inline image widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widget instance.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static IInlineImageWidget InlineImage(this IWebWidgetsCreator creator) => creator is not null ? new InlineImageWidget() : throw new ArgumentNullException(nameof(creator));

  /// <summary>
  ///   <para>Creates new inline image widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="InlineImage(IWebWidgetCreator)"/>
  public static string InlineImage(this IWebWidgetsCreator creator, Action<IInlineImageWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.InlineImage();

    builder(widget);
      
    return widget.ToHtml();
  }
}