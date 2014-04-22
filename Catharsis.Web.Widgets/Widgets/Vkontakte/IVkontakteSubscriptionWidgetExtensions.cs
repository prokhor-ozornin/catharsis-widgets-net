using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteSubscriptionWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontakteSubscriptionWidget"/>
  public static class IVkontakteSubscriptionWidgetExtensions
  {
    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteSubscriptionWidget.Layout(byte)"/>
    public static IVkontakteSubscriptionWidget Layout(this IVkontakteSubscriptionWidget widget, VkontakteSubscribeButtonLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout((byte)layout);
    }
  }
}