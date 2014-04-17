using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extensions for interface <see cref="ISoundCloudProfileIconWidget"/>.</para>
  /// </summary>
  /// <seealso cref="ISoundCloudProfileIconWidget"/>
  public static class ISoundCloudProfileIconWidgetExtensions
  {
    /// <summary>
    ///   <para>Sets color of profile icon to black-and-white pattern.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public static ISoundCloudProfileIconWidget BlackWhite(this ISoundCloudProfileIconWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("black_white");
    }

    /// <summary>
    ///   <para>Sets color of profile icon to transparent-orange pattern.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public static ISoundCloudProfileIconWidget OrangeTransparent(this ISoundCloudProfileIconWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("orange_transparent");
    }

    /// <summary>
    ///   <para>Sets color of profile icon to orange-and-white pattern.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public static ISoundCloudProfileIconWidget OrangeWhite(this ISoundCloudProfileIconWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("orange_white");
    }

    /// <summary>
    ///   <para>Edge size of profile icon in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Icon's size.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Size(short)"/>
    public static ISoundCloudProfileIconWidget Size(this ISoundCloudProfileIconWidget widget, SoundCloudProfileIconSize size)
    {
      Assertion.NotNull(widget);

      return widget.Size((short)size);
    }

    /// <summary>
    ///   <para>Sets color of profile icon to white-and-orange pattern.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public static ISoundCloudProfileIconWidget WhiteOrange(this ISoundCloudProfileIconWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("white_orange");
    }

    /// <summary>
    ///   <para>Sets color of profile icon to transparent-white pattern.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudProfileIconWidget.Color(string)"/>
    public static ISoundCloudProfileIconWidget WhiteTransparent(this ISoundCloudProfileIconWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("white_transparent");
    }
  }
}