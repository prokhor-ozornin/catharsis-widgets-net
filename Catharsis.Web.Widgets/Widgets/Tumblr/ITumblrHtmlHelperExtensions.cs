using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ITumblrHtmlHelper"/>.</para>
  ///   <seealso cref="ITumblrHtmlHelper"/>
  /// </summary>
  public static class ITumblrHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Tumblr "Follow" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrHtmlHelper.Follow()"/>
    public static string Follow(this ITumblrHtmlHelper html, Action<ITumblrFollowButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Follow();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Tumblr "Share" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrHtmlHelper.Share()"/>
    public static string Share(this ITumblrHtmlHelper html, Action<ITumblrShareButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Share();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}