using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IPayPalHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IPayPalHtmlHelper"/>
  public static class IPayPalHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new PayPal "Buy Gift Certificate" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPayPalHtmlHelper.BuyGiftCertificate()"/>
    public static string BuyGiftCertificate(this IPayPalHtmlHelper html, Action<IPayPalBuyGiftCertificateWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.BuyGiftCertificate();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new PayPal "Buy Now" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPayPalHtmlHelper.BuyGiftCertificate()"/>
    public static string BuyNow(this IPayPalHtmlHelper html, Action<IPayPalBuyNowWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.BuyNow();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new PayPal "Donate" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPayPalHtmlHelper.BuyGiftCertificate()"/>
    public static string Donate(this IPayPalHtmlHelper html, Action<IPayPalDonateWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Donate();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new PayPal "Subscribe" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPayPalHtmlHelper.BuyGiftCertificate()"/>
    public static string SubscribeButton(this IPayPalHtmlHelper html, Action<IPayPalSubscribeWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Subscribe();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}