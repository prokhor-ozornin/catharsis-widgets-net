using System;
using System.Web;
using System.Web.Optimization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IWidgetsScriptsRenderer"/>.</para>
  /// </summary>
  /// <seealso cref="IWidgetsScriptsRenderer"/>
  public static partial class IWidgetsScriptsRendererExtensions
  {
    /// <summary>
    ///   <para>Renders required JavaScript tags for Google widgets.</para>
    /// </summary>
    /// <param name="renderer">JavaScript code renderer.</param>
    /// <returns>JavaScript code.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="renderer"/> is a <c>null</c> reference.</exception>
    public static IHtmlString Google(this IWidgetsScriptsRenderer renderer)
    {
      Assertion.NotNull(renderer);

      return Scripts.Render("~/WebWidgets/Google");
    }
  }
}