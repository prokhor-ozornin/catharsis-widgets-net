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
    ///   <para>Initializes inline image widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widget instance.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IInlineImageWidget InlineImage(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return new InlineImageWidget();
    }
  }
}