using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVideoJSHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IVideoJSHtmlHelper"/>
  public static class IVideoJSHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new VideoJS player widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVideoJSHtmlHelper.Player()"/>
    public static string Player(this IVideoJSHtmlHelper html, Action<IVideoJSPlayerWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Player();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}