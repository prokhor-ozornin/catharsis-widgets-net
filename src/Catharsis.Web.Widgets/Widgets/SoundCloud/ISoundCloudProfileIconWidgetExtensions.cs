namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extensions for interface <see cref="ISoundCloudProfileIconWidget"/>.</para>
/// </summary>
/// <seealso cref="ISoundCloudProfileIconWidget"/>
public static class ISoundCloudProfileIconWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(ISoundCloudProfileIconWidget widget)
  {
    /// <summary>
    ///   <para>Sets color of profile icon to black-and-white pattern.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public ISoundCloudProfileIconWidget BlackWhite() => widget?.Color("black_white") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets color of profile icon to transparent-orange pattern.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public ISoundCloudProfileIconWidget OrangeTransparent() => widget?.Color("orange_transparent") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets color of profile icon to orange-and-white pattern.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public ISoundCloudProfileIconWidget OrangeWhite() => widget?.Color("orange_white") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Edge size of profile icon in pixels.</para>
    /// </summary>
    /// <param name="size">Icon's size.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Size(short)"/>
    public ISoundCloudProfileIconWidget Size(SoundCloudProfileIconSize size) => widget?.Size((short) size) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets color of profile icon to white-and-orange pattern.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public ISoundCloudProfileIconWidget WhiteOrange() => widget?.Color("white_orange") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets color of profile icon to transparent-white pattern.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public ISoundCloudProfileIconWidget WhiteTransparent() => widget?.Color("white_transparent") ?? throw new ArgumentNullException(nameof(widget));
  }
}