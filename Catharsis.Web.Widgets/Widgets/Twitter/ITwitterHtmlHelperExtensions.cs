using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ITwitterHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="ITwitterHtmlHelper"/>
  public static class ITwitterHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>reates new Twitter "Follow" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterHtmlHelper.Follow()"/>
    public static string Follow(this ITwitterHtmlHelper html, Action<ITwitterFollowButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Follow();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Twitter "Tweet" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterHtmlHelper.Tweet()"/>
    public static string Tweet(this ITwitterHtmlHelper html, Action<ITwitterTweetButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Tweet();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}