using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Disqus comments widget for registered website.</para>
  ///   <para>Requires Disqus scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://disqus.com/websites"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Disqus(IWidgetsScriptsRenderer)"/>
  public class DisqusCommentsWidget : HtmlWidget, IDisqusCommentsWidget
  {
    private string account;

    /// <summary>
    ///   <para>Identifier of registered website in the "Disqus" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IDisqusCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty())
      {
        return string.Empty;
      }

      return resources.disqus_comments.FormatSelf(this.account);
    }
  }
}