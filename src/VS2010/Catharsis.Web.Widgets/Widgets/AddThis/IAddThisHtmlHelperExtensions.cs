using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IAddThisHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IAddThisHtmlHelper"/>
  public static class IAddThisHtmlHelperExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="html"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IAddThisHtmlHelper.SmartLayers()"/>
    public static string SmartLayers(this IAddThisHtmlHelper html, Action<IAddThisSmartLayersWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.SmartLayers();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="html"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IAddThisHtmlHelper.ShareButtons()"/>
    public static string ShareButtons(this IAddThisHtmlHelper html, Action<IAddThisShareButtonsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.ShareButtons();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="html"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IAddThisHtmlHelper.FollowButtons()"/>
    public static string FollowButtons(this IAddThisHtmlHelper html, Action<IAddThisFollowButtonsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.FollowButtons();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="html"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IAddThisHtmlHelper.WelcomeBar()"/>
    public static string WelcomeBar(this IAddThisHtmlHelper html, Action<IAddThisWelcomeBarWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.WelcomeBar();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="html"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IAddThisHtmlHelper.TrendingContent()"/>
    public static string TrendingContent(this IAddThisHtmlHelper html, Action<IAddThisTrendingContentWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.TrendingContent();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}