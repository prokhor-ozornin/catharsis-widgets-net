using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IIntenseDebateHtmlHelper"/>.</para>
  ///   <seealso cref="IIntenseDebateHtmlHelper"/>
  /// </summary>
  public static class IIntenseDebateHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new IntenseDebate comments widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IIntenseDebateHtmlHelper.Comments()"/>
    public static string Comments(this IIntenseDebateHtmlHelper html, Action<IIntenseDebateCommentsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Comments();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}