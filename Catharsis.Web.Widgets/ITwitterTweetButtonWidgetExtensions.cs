using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ITwitterTweetButtonWidget"/>.</para>
  ///   <seealso cref="ITwitterTweetButtonWidget"/>
  /// </summary>
  public static class ITwitterTweetButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Specifies language for the "Tweet" button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="culture">Interface language for button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.Language(string)"/>
    public static ITwitterTweetButtonWidget Language(this ITwitterTweetButtonWidget widget, CultureInfo culture)
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(culture);

      return widget.Language(culture.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>Specifies the size of the rendered button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.Size(string)"/>
    public static ITwitterTweetButtonWidget Size(this ITwitterTweetButtonWidget widget, TwitterTweetButtonSize size)
    {
      Assertion.NotNull(widget);

      return widget.Size(Enum.GetName(typeof(TwitterTweetButtonSize), size).ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Specifies count box position.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.CountPosition(string)"/>
    public static ITwitterTweetButtonWidget CountPosition(this ITwitterTweetButtonWidget widget, TwitterTweetButtonCountBoxPosition position)
    {
      Assertion.NotNull(widget);

      return widget.CountPosition(Enum.GetName(typeof(TwitterTweetButtonCountBoxPosition), position).ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Specifies collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="tags"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
    public static ITwitterTweetButtonWidget HashTags(this ITwitterTweetButtonWidget widget, params string[] tags)
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(tags);

      return widget.HashTags(tags);
    }

    /// <summary>
    ///   <para>Specifies collection of related accounts.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
    public static ITwitterTweetButtonWidget RelatedAccounts(this ITwitterTweetButtonWidget widget, params string[] accounts)
    {
      Assertion.NotNull(widget);

      return widget.RelatedAccounts(accounts);
    }
  }
}