namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IInlineImageWidget"/>.</para>
/// </summary>
/// <seealso cref="IInlineImageWidget"/>
public static class IInlineImageExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IInlineImageWidget widget)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IInlineImageWidget Jpg() => widget?.Format("jpg") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IInlineImageWidget Png() => widget?.Format("png") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IInlineImageWidget Gif() => widget?.Format("gif") ?? throw new ArgumentNullException(nameof(widget));
  }
}