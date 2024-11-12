using System;
using System.Globalization;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extensions methods for interface <see cref="IVkontakteAuthButtonWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontakteAuthButtonWidget"/>
  public static class IVkontakteAuthButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Horizontal width of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontakteAuthButtonWidget Width(this IVkontakteAuthButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Uses "standard" authentication mode with URL redirection.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="url">URL to be redirected to.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public static IVkontakteAuthButtonWidget Standard(this IVkontakteAuthButtonWidget widget, string url)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      return widget.Type(VkontakteAuthButtonType.Standard).Url(url);
    }

    /// <summary>
    ///   <para>Uses "dynamic" authentication mode with JavaScript callback function.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="callback">JavaScript callback function.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="callback"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
    public static IVkontakteAuthButtonWidget Dynamic(this IVkontakteAuthButtonWidget widget, string callback)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (callback is null) throw new ArgumentNullException(nameof(callback));
      if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

      return widget.Type(VkontakteAuthButtonType.Dynamic).Callback(callback);
    }
  }
}