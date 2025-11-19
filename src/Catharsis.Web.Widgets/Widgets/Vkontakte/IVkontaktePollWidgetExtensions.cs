using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontaktePollWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontaktePollWidget"/>
public static class IVkontaktePollWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IVkontaktePollWidget widget)
  {
    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IVkontaktePollWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
    public IVkontaktePollWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}