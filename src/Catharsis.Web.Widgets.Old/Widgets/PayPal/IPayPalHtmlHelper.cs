namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing PayPal widgets.</para>
  /// </summary>
  public interface IPayPalHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new PayPal "Buy Gift Certificate" widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPayPalBuyGiftCertificateWidget BuyGiftCertificate();

    /// <summary>
    ///   <para>Creates new PayPal "Buy Now" widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPayPalBuyNowWidget BuyNow();

    /// <summary>
    ///   <para>Creates new PayPal "Donate" widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPayPalDonateWidget Donate();

    /// <summary>
    ///   <para>Creates new PayPal "Subscribe" widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPayPalSubscribeWidget Subscribe();
  }
}