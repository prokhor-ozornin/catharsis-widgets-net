using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IDisqusHtmlHelper"/>.</para>
  ///   <seealso cref="IDisqusHtmlHelper"/>
  /// </summary>
  public static class IDisqusHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Disqus comments widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IDisqusHtmlHelper.Comments()"/>
    public static string Comments(this IDisqusHtmlHelper html, Action<IDisqusCommentsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Comments();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}