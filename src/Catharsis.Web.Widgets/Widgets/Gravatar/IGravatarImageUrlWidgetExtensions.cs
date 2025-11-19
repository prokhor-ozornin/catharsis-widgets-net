using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGravatarImageUrlWidget"/>.</para>
/// </summary>
/// <seealso cref="IGravatarImageUrlWidget"/>
public static class IGravatarImageUrlWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IGravatarImageUrlWidget widget)
  {
    /// <summary>
    ///   <para>URL of image to be returned when user's email address has no matching Gravatar image.</para>
    /// </summary>
    /// <param name="url">URL of default image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="Default(IGravatarImageUrlWidget, GravatarDefaultImage)"/>
    public IGravatarImageUrlWidget Default(string url)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      return widget.Parameter("default", url);
    }

    /// <summary>
    ///   <para>Predefined type of image to be returned when user's email address has no matching Gravatar image.</para>
    /// </summary>
    /// <param name="image">Type of default image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="Default(IGravatarImageUrlWidget, string)"/>
    public IGravatarImageUrlWidget Default(GravatarDefaultImage image)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      return image switch
      {
        GravatarDefaultImage.Blank => widget.Default("blank"),
        GravatarDefaultImage.IdentIcon => widget.Default("identicon"),
        GravatarDefaultImage.MonsterId => widget.Default("monsterid"),
        GravatarDefaultImage.MysteryMan => widget.Default("mm"),
        GravatarDefaultImage.Retro => widget.Default("retro"),
        GravatarDefaultImage.Wavatar => widget.Default("wavatar"),
        _ => widget.Default("404")
      };
    }

    /// <summary>
    ///   <para>Email address of the user whose avatar is requested.</para>
    /// </summary>
    /// <param name="email">User's email address.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="email"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="email"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="IGravatarImageUrlWidget.Hash(string)"/>
    /// <remarks>Either user's email or email's hash must be specified to render the widget.</remarks>
    public IGravatarImageUrlWidget Email(string email)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (email is null) throw new ArgumentNullException(nameof(email));
      if (email.IsEmpty()) throw new ArgumentException(nameof(email));

      return widget.Hash(email.Trim().ToLowerInvariant().ToBytes(Encoding.ASCII).HashMd5().ToHex().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Forces default image to be loaded as a user's avatar.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IGravatarImageUrlWidget ForceDefault() => widget?.Parameter("forcedefault", "y") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Rating of avatar's image that represents audience restrictions.</para>
    /// </summary>
    /// <param name="rating">Rating of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="rating"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="rating"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="Rating(IGravatarImageUrlWidget, GravatarImageRating)"/>
    public IGravatarImageUrlWidget Rating(string rating)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (rating is null) throw new ArgumentNullException(nameof(rating));
      if (rating.IsEmpty()) throw new ArgumentException(nameof(rating));

      return widget.Parameter("rating", rating);
    }

    /// <summary>
    ///   <para>Rating of avatar's image that represents audience restrictions.</para>
    /// </summary>
    /// <param name="rating">Rating of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="Rating(IGravatarImageUrlWidget, string)"/>
    public IGravatarImageUrlWidget Rating(GravatarImageRating rating) => widget?.Rating(rating.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Size of avatar's image in pixels (both width and height).</para>
    /// </summary>
    /// <param name="size">Size of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IGravatarImageUrlWidget Size(short size) => widget?.Parameter("size", size) ?? throw new ArgumentNullException(nameof(widget));
  }
}