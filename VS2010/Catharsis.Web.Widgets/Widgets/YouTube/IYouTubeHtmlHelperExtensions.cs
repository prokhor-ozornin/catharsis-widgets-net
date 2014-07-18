using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for itnerface <see cref="IYouTubeHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IYouTubeHtmlHelper"/>
  public static class IYouTubeHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new YouTube embedded video widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYouTubeHtmlHelper.Video()"/>
    public static string Video(this IYouTubeHtmlHelper html, Action<IYouTubeVideoWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Video();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}