using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontakteCommentsWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteCommentsWidget"/>
public static class IVkontakteCommentsWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IVkontakteCommentsWidget widget)
  {
    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <param name="limit">Maximum number of comments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Limit(byte)"/>
    public IVkontakteCommentsWidget Limit(VkontakteCommentsLimit limit) => widget?.Limit((byte) limit) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="types">Allowed types of post attachments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Attach(string[])"/>
    public IVkontakteCommentsWidget Attach(params VkontakteCommentsAttach[] types) => widget?.Attach(types.Select(item => item == VkontakteCommentsAttach.All ? "*" : item.ToString().ToLowerInvariant()).ToArray()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <param name="width">Width of comments widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Width(string)"/>
    public IVkontakteCommentsWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}