using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IShare42HtmlHelper"/>.</para>
  ///   <seealso cref="IShare42HtmlHelper"/>
  /// </summary>
  public static class IShare42HtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates nwe Share42 Panel widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IShare42HtmlHelper.Panel()"/>
    public static string Panel(this IShare42HtmlHelper html, Action<IShare42PanelWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Panel();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}