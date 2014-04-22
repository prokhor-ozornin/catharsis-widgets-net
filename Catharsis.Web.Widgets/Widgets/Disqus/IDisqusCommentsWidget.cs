using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Disqus comments widget for registered website.</para>
  ///   <para>Requires <see cref="WebWidgetsScriptsBundles.Disqus"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://disqus.com/websites"/>
  public interface IDisqusCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered website in the "Disqus" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IDisqusCommentsWidget Account(string account);
  }
}