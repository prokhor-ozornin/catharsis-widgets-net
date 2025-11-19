namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexMoneyButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexMoneyButtonWidget"/>
public static class IYandexMoneyButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IYandexMoneyButtonWidget widget)
  {
    /// <summary>
    ///   <para>Color of button.</para>
    /// </summary>
    /// <param name="color">Button's color.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexMoneyButtonWidget.Color(string)"/>
    public IYandexMoneyButtonWidget Color(YandexMoneyButtonColor color) => widget?.Color(color.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Size of button.</para>
    /// </summary>
    /// <param name="size">Button's size.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyButtonWidget Size(YandexMoneyButtonSize size)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      return size switch
      {
        YandexMoneyButtonSize.Small => widget.Size("s"),
        YandexMoneyButtonSize.Medium => widget.Size("m"),
        YandexMoneyButtonSize.Large => widget.Size("l"),
        _ => widget.Size("l")
      };
    }

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyButtonWidget Sum(double sum) => widget?.Sum((decimal) sum) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Text to display on button.</para>
    /// </summary>
    /// <param name="text">Numeric text type to display.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyButtonWidget Text(YandexMoneyButtonText text) => widget?.Text((byte) text) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Type of payment option.</para>
    /// </summary>
    /// <param name="type">Payment source.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyButtonWidget Type(YandexMoneyButtonType type)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      return type switch
      {
        YandexMoneyButtonType.Card => widget.Type("any-card-payment-type"),
        YandexMoneyButtonType.Wallet => widget.Type("yamoney-payment-type"),
        _ => widget.Type("yamoney-payment-type")
      };
    }
  }
}