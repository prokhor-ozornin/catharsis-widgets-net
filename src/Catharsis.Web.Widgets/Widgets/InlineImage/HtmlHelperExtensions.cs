using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
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
    public static IInlineImageWidget InlineImage(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return new InlineImageWidget();
    }

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
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.InlineImage();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}