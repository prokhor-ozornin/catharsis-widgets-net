namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Rate of image that indicates whether it's appropriate for a certain audience.</para>
  /// </summary>
  public enum GravatarImageRating
  {
    /// <summary>
    ///   <para>Suitable for display on all websites with any audience type.</para>
    /// </summary>
    G,

    /// <summary>
    ///   <para>May contain rude gestures, provocatively dressed individuals, the lesser swear words, or mild violence.</para>
    /// </summary>
    PG,

    /// <summary>
    ///   <para>May contain such things as harsh profanity, intense violence, nudity, or hard drug use.</para>
    /// </summary>
    R,

    /// <summary>
    ///   <para>May contain hardcore sexual imagery or extremely disturbing violence.</para>
    /// </summary>
    X
  }
}