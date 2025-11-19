using Catharsis.Extensions;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookActivityFeedWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookActivityFeedWidget"/>
  public static class IFacebookActivityFeedWidgetExtensions
  {
    /// <param name="widget">Widget to call method on.</param>
    extension(IFacebookActivityFeedWidget widget)
    {
      /// <summary>
      ///   <para>Collection of Open Graph action types to show in the feed.</para>
      /// </summary>
      /// <param name="actions">Collection of Facebook action types.</param>
      /// <returns>Reference to the current widget.</returns>
      /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
      /// <seealso cref="IFacebookActivityFeedWidget.Actions(IEnumerable{string})"/>
      public IFacebookActivityFeedWidget Actions(params string[] actions) => widget?.Actions(actions) ?? throw new ArgumentNullException(nameof(widget));

      /// <summary>
      ///   <para>The width of the widget in pixels.</para>
      /// </summary>
      /// <param name="width">Width of widget.</param>
      /// <returns>Reference to the current widget.</returns>
      /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
      /// <seealso cref="IFacebookActivityFeedWidget.Width(string)"/>
      public IFacebookActivityFeedWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

      /// <summary>
      ///   <para>The height of the widget in pixels.</para>
      /// </summary>
      /// <param name="height">Height of widget.</param>
      /// <returns>Reference to the current widget.</returns>
      /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
      /// <exception cref="IFacebookActivityFeedWidget.Height(string)"/>
      public IFacebookActivityFeedWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

      /// <summary>
      ///   <para>The color scheme used by the widget.</para>
      /// </summary>
      /// <param name="scheme">Color scheme of widget.</param>
      /// <returns>Reference to the current widget.</returns>
      /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
      /// <seealso cref="IFacebookActivityFeedWidget.ColorScheme(string)"/>
      public IFacebookActivityFeedWidget ColorScheme(FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
    }
  }
}