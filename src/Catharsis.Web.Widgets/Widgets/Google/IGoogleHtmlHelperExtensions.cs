using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IGoogleHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IGoogleHtmlHelper"/>
  public static class IGoogleHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Google Analytics widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGoogleHtmlHelper.Analytics()"/>
    public static string Analytics(this IGoogleHtmlHelper html, Action<IGoogleAnalyticsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Analytics();
      builder(widget);
      return widget.ToHtmlString();
    }

    /*/// <summary>
    ///   <para>Creates new Google Map widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGoogleHtmlHelper.Map()"/>
    public static string Map(this IGoogleHtmlHelper html, Action<IGoogleMapWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Map();
      builder(widget);
      return widget.ToHtmlString();
    }*/

    /// <summary>
    ///   <para>Creates new Google "+1" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGoogleHtmlHelper.PlusOneButton()"/>
    public static string PlusOneButton(this IGoogleHtmlHelper html, Action<IGooglePlusOneButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.PlusOneButton();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}