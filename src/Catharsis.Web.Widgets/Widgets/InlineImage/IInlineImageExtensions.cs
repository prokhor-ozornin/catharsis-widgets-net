namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IInlineImageWidget"/>.</para>
/// </summary>
/// <seealso cref="IInlineImageWidget"/>
public static class IInlineImageExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static IInlineImageWidget Jpg(this IInlineImageWidget widget) => widget?.Format("jpg") ?? throw new ArgumentNullException(nameof(widget));
    
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static IInlineImageWidget Png(this IInlineImageWidget widget) => widget?.Format("png") ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static IInlineImageWidget Gif(this IInlineImageWidget widget) => widget?.Format("gif") ?? throw new ArgumentNullException(nameof(widget));
}