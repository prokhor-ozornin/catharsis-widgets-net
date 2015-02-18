using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IPinterestHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IPinterestHtmlHelper"/>
  public static class IPinterestHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Pinterest Board widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestHtmlHelper.Board()"/>
    public static string Board(this IPinterestHtmlHelper html, Action<IPinterestBoardWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Board();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Pinterest "Follow Me" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestHtmlHelper.FollowButton()"/>
    public static string FollowButton(this IPinterestHtmlHelper html, Action<IPinterestFollowButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.FollowButton();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Pinterest "Pin It" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestHtmlHelper.PinItButton()"/>
    public static string PinItButton(this IPinterestHtmlHelper html, Action<IPinterestPinItButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.PinItButton();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Pinterest embedded pin widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestHtmlHelper.Pin()"/>
    public static string Pin(this IPinterestHtmlHelper html, Action<IPinterestPinWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Pin();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Pinterest Profile widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestHtmlHelper.Profile()"/>
    public static string Profile(this IPinterestHtmlHelper html, Action<IPinterestProfileWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Profile();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}