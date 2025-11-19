using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontaktePostWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontaktePostWidget"/>
public static class IVkontaktePostWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IVkontaktePostWidget widget)
  {
    /// <summary>
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <param name="id">Identifier of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IVkontaktePostWidget Id(long id) => widget?.Id(id.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <param name="id">Identifier of wall's owner.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IVkontaktePostWidget Owner(long id) => widget?.Owner(id.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of wall's post. Default is the width of entire screen.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IVkontaktePostWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}