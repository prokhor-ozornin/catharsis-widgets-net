using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IGravatarHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IGravatarHtmlHelper"/>
  public static class IGravatarHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Gravatar's avatar URL widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarHtmlHelper.ImageUrl()"/>
    public static string ImageUrl(this IGravatarHtmlHelper html, Action<IGravatarImageUrlWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.ImageUrl();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Gravatar's user profile URL widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarHtmlHelper.ProfileUrl()"/>
    public static string ProfileUrl(this IGravatarHtmlHelper html, Action<IGravatarProfileUrlWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.ProfileUrl();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}