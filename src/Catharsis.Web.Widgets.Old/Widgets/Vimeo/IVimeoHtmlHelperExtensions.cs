using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVimeoHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IVimeoHtmlHelper"/>
  public static class IVimeoHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Vimeo embedded video widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVimeoHtmlHelper.Video()"/>
    public static string Video(this IVimeoHtmlHelper html, Action<IVimeoVideoWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      var widget = html.Video();

      builder(widget);
      
      return widget.ToHtmlString();
    }
  }
}