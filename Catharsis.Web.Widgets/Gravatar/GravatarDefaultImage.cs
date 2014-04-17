namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Type of default image for Gravatar's avatar.</para>
  /// </summary>
  public enum GravatarDefaultImage
  {
    /// <summary>
    ///   <para>Do not load any image if none is associated with the email hash, instead return an HTTP 404 (File Not Found) response.</para>
    /// </summary>
    NotFound,

    /// <summary>
    ///   <para>A simple, cartoon-style silhouetted outline of a person (does not vary by email hash).</para>
    /// </summary>
    MysteryMan,

    /// <summary>
    ///   <para>A geometric pattern based on an email hash.</para>
    /// </summary>
    IdentIcon,

    /// <summary>
    ///   <para>A generated 'monster' with different colors, faces, etc.</para>
    /// </summary>
    MonsterId,

    /// <summary>
    ///   <para>Generated faces with differing features and backgrounds.</para>
    /// </summary>
    Wavatar,

    /// <summary>
    ///   <para>Awesome generated, 8-bit arcade-style pixelated faces.</para>
    /// </summary>
    Retro,

    /// <summary>
    ///   <para>A transparent PNG image (border added to HTML below for demonstration purposes).</para>
    /// </summary>
    Blank
  }
}