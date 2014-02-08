using System;
using System.Globalization;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteCommentsWidget"/>.</para>
  ///   <seealso cref="IVkontakteCommentsWidget"/>
  /// </summary>
  public static class IVkontakteCommentsWidgetExtensions
  {
    /// <summary>
    ///   <para>Specifies maximum number of comments to display.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="limit">Maximum number of comments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Limit(byte)"/>
    public static IVkontakteCommentsWidget Limit(this IVkontakteCommentsWidget widget, VkontakteCommentsLimit limit)
    {
      Assertion.NotNull(widget);

      return widget.Limit((byte)limit);
    }

    /// <summary>
    ///   <para>Specifies collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="attach">Allowed types of post attachments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Attach(string[])"/>
    public static IVkontakteCommentsWidget Attach(this IVkontakteCommentsWidget widget, params VkontakteCommentsAttach[] attach)
    {
      Assertion.NotNull(widget);

      return widget.Attach(attach.Select(item => item == VkontakteCommentsAttach.All ? "*" : Enum.GetName(typeof(VkontakteCommentsAttach), item).ToLowerInvariant()).ToArray());
    }

    /// <summary>
    ///   <para>Specifies horizontal width of comment area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of comments widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Width(string)"/>
    public static IVkontakteCommentsWidget Width(this IVkontakteCommentsWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}