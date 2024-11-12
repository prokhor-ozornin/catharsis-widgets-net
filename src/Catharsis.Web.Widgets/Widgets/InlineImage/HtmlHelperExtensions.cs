using System.Web.Mvc;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for class <see cref="HtmlHelper"/>.</para>
/// </summary>
/// <seealso cref="HtmlHelper"/>
public static partial class HtmlHelperExtensions
{
  /// <summary>
  ///   <para>Creates new inline image widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <returns>Widget instance.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
  public static IInlineImageWidget InlineImage(this HtmlHelper html) => html is not null ? new InlineImageWidget() : throw new ArgumentNullException(nameof(html));

  /// <summary>
  ///   <para>Creates new inline image widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="InlineImage(HtmlHelper)"/>
  public static string InlineImage(this HtmlHelper html, Action<IInlineImageWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.InlineImage();

    builder(widget);
      
    return widget.ToHtml();
  }
}