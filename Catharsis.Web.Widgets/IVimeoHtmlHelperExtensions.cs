using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVimeoHtmlHelper"/>.</para>
  ///   <seealso cref="IVimeoHtmlHelper"/>
  /// </summary>
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
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Video();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Vimeo video hyperlink widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVimeoHtmlHelper.VideoLink()"/>
    public static string VideoLink(this IVimeoHtmlHelper html, Action<IVimeoVideoLinkWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.VideoLink();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}