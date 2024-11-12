using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IMailRuHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IMailRuHtmlHelper"/>
  public static class IMailRuHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Mail.ru Faces (People On Site) widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuHtmlHelper.Faces()"/>
    public static string Faces(this IMailRuHtmlHelper html, Action<IMailRuFacesWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));
      
      var widget = html.Faces();
      
      builder(widget);
      
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Mail.ru Group (People In Group) widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuHtmlHelper.Groups()"/>
    public static string Groups(this IMailRuHtmlHelper html, Action<IMailRuGroupsWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      var widget = html.Groups();

      builder(widget);
      
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Mail.ru ICQ On-Site widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuHtmlHelper.Icq()"/>
    public static string Icq(this IMailRuHtmlHelper html, Action<IMailRuIcqWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      var widget = html.Icq();

      builder(widget);
      
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Mail.ru "Like" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuHtmlHelper.LikeButton()"/>
    public static string LikeButton(this IMailRuHtmlHelper html, Action<IMailRuLikeButtonWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      var widget = html.LikeButton();

      builder(widget);
      
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Mail.ru embedded video widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuHtmlHelper.Video()"/>
    public static string Video(this IMailRuHtmlHelper html, Action<IMailRuVideoWidget> builder)
    {
      if (html is null) throw new ArgumentNullException(nameof(html));
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      var widget = html.Video();

      builder(widget);
      
      return widget.ToHtmlString();
    }
  }
}