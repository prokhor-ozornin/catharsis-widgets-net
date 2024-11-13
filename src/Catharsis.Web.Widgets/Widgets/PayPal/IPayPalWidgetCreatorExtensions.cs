namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IPayPalWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IPayPalWidgetCreator"/>
public static class IPayPalWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new PayPal "Buy Gift Certificate" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPayPalWidgetCreator.BuyGiftCertificate()"/>
  public static string BuyGiftCertificate(this IPayPalWidgetCreator creator, Action<IPayPalBuyGiftCertificateWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.BuyGiftCertificate();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new PayPal "Buy Now" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPayPalWidgetCreator.BuyGiftCertificate()"/>
  public static string BuyNow(this IPayPalWidgetCreator creator, Action<IPayPalBuyNowWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.BuyNow();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new PayPal "Donate" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPayPalWidgetCreator.BuyGiftCertificate()"/>
  public static string Donate(this IPayPalWidgetCreator creator, Action<IPayPalDonateWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Donate();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new PayPal "Subscribe" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPayPalWidgetCreator.BuyGiftCertificate()"/>
  public static string SubscribeButton(this IPayPalWidgetCreator creator, Action<IPayPalSubscribeWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Subscribe();
     
    builder(widget);
      
    return widget.ToHtml();
  }
}