using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITwitterTweetButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="ITwitterTweetButtonWidget"/>
public static class ITwitterTweetButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(ITwitterTweetButtonWidget widget)
  {
    /// <summary>
    ///   <para>Language for the "Tweet" button.</para>
    /// </summary>
    /// <param name="culture">Interface language for button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.Language(string)"/>
    public ITwitterTweetButtonWidget Language(CultureInfo culture)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (culture is null) throw new ArgumentNullException(nameof(culture));

      return widget.Language(culture.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>The size of the rendered button.</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.Size(string)"/>
    public ITwitterTweetButtonWidget Size(TwitterTweetButtonSize size) => widget?.Size(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Count box position.</para>
    /// </summary>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.CounterPosition(string)"/>
    public ITwitterTweetButtonWidget CounterPosition(TwitterTweetButtonCountBoxPosition position) => widget?.CounterPosition(position.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="tags"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
    public ITwitterTweetButtonWidget HashTags(params string[] tags)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (tags is null) throw new ArgumentNullException(nameof(tags));

      return widget.HashTags(tags);
    }

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
    public ITwitterTweetButtonWidget RelatedAccounts(params string[] accounts) => widget?.RelatedAccounts(accounts) ?? throw new ArgumentNullException(nameof(widget));
  }
}