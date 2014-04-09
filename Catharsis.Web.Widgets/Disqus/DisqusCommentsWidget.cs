using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Disqus comments widget for registered website.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Disqus"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://disqus.com/websites"/>
  public sealed class DisqusCommentsWidget : HtmlWidgetBase, IDisqusCommentsWidget
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      writer.Write(resources.disqus_comments.FormatSelf(this.account));
    }
  }
}