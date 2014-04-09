using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ISurfingbirdHtmlHelper"/>.</para>
  ///   <seealso cref="ISurfingbirdHtmlHelper"/>
  /// </summary>
  public static class ISurfingbirdHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Surfingbird "Surf" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISurfingbirdHtmlHelper.Surf()"/>
    public static string Surf(this ISurfingbirdHtmlHelper html, Action<ISurfingbirdSurfButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Surf();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}