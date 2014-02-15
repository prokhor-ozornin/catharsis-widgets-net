using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Initializes Cackle comments count widget to show comments count with hyperlinks.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  ///   <seealso cref="http://ru.cackle.me/help/widget-api"/>
  /// </summary>
  public interface ICackleCommentsCountWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ICackleCommentsCountWidget Account(string account);
  }
}