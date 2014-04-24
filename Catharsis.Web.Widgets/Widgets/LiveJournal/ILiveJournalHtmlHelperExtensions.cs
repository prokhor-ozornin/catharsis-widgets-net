using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ILiveJournalHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="ILiveJournalHtmlHelper"/>
  public static class ILiveJournalHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new LiveJournal "Like" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ILiveJournalHtmlHelper.LikeButton()"/>
    public static string LikeButton(this ILiveJournalHtmlHelper html, Action<ILiveJournalLikeButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.LikeButton();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new LiveJournal "Repost" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ILiveJournalHtmlHelper.RepostButton()"/>
    public static string RepostButton(this ILiveJournalHtmlHelper html, Action<ILiveJournalRepostButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.RepostButton();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}