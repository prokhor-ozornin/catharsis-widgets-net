using System;
using System.Text;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IGravatarImageUrlWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IGravatarImageUrlWidget"/>
  public static class IGravatarImageUrlWidgetExtensions
  {
    /// <summary>
    ///   <para>URL of image to be returned when user's email address has no matching Gravatar image.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="url">URL of default image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="Default(IGravatarImageUrlWidget, GravatarDefaultImage)"/>
    public static IGravatarImageUrlWidget Default(this IGravatarImageUrlWidget widget, string url)
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(url);

      return widget.Parameter("default", url);
    }

    /// <summary>
    ///   <para>Predefined type of image to be returned when user's email address has no matching Gravatar image.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="image">Type of default image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="Default(IGravatarImageUrlWidget, string)"/>
    public static IGravatarImageUrlWidget Default(this IGravatarImageUrlWidget widget, GravatarDefaultImage image)
    {
      Assertion.NotNull(widget);

      switch (image)
      {
        case GravatarDefaultImage.Blank :
          return widget.Default("blank");

        case GravatarDefaultImage.IdentIcon :
          return widget.Default("identicon");

        case GravatarDefaultImage.MonsterId :
          return widget.Default("monsterid");

        case GravatarDefaultImage.MysteryMan :
          return widget.Default("mm");

        case GravatarDefaultImage.Retro :
          return widget.Default("retro");

        case GravatarDefaultImage.Wavatar :
          return widget.Default("wavatar");

        default:
          return widget.Default("404");
      }
    }

    /// <summary>
    ///   <para>Email address of the user whose avatar is requested.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="email">User's email address.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="email"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="email"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="IGravatarImageUrlWidget.Hash(string)"/>
    /// <remarks>Either user's email or email's hash must be specified to render the widget.</remarks>
    public static IGravatarImageUrlWidget Email(this IGravatarImageUrlWidget widget, string email)
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(email);

      return widget.Hash(email.Trim().ToLowerInvariant().Bytes(Encoding.ASCII, false).MD5().Hex().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Forces default image to be loaded as a user's avatar.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IGravatarImageUrlWidget ForceDefault(this IGravatarImageUrlWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Parameter("forcedefault", "y");
    }

    /// <summary>
    ///   <para>Rating of avatar's image that represents audience restrictions.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="rating">Rating of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="rating"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="rating"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="Rating(IGravatarImageUrlWidget, GravatarImageRating)"/>
    public static IGravatarImageUrlWidget Rating(this IGravatarImageUrlWidget widget, string rating)
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(rating);

      return widget.Parameter("rating", rating);
    }

    /// <summary>
    ///   <para>Rating of avatar's image that represents audience restrictions.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="rating">Rating of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="Rating(IGravatarImageUrlWidget, string)"/>
    public static IGravatarImageUrlWidget Rating(this IGravatarImageUrlWidget widget, GravatarImageRating rating)
    {
      Assertion.NotNull(widget);

      return widget.Rating(rating.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Size of avatar's image in pixels (both width and height).</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Size of image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IGravatarImageUrlWidget Size(this IGravatarImageUrlWidget widget, short size)
    {
      Assertion.NotNull(widget);

      return widget.Parameter("size", size);
    }
  }
}