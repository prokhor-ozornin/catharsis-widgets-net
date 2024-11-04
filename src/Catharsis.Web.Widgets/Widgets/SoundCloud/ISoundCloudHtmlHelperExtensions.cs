using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ISoundCloudHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="ISoundCloudHtmlHelper"/>
  public static class ISoundCloudHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new SoundCloud profile icon widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISoundCloudHtmlHelper.ProfileIcon()"/>
    public static string ProfileIcon(this ISoundCloudHtmlHelper html, Action<ISoundCloudProfileIconWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.ProfileIcon();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}