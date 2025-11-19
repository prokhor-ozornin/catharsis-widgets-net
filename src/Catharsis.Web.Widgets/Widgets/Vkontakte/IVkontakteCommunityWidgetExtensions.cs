using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontakteCommunityWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteCommunityWidget"/>
public static class IVkontakteCommunityWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IVkontakteCommunityWidget widget)
  {
    /// <summary>
    ///   <para>Type of information to be displayed about given community.</para>
    /// </summary>
    /// <param name="mode">Community's info type.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Mode(byte)"/>
    public IVkontakteCommunityWidget Mode(VkontakteCommunityMode mode) => widget?.Mode((byte) mode) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Width(string)"/>
    public IVkontakteCommunityWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommunityWidget.Height(string)"/>
    public IVkontakteCommunityWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}