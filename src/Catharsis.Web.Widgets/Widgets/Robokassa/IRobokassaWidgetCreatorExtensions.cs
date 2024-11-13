namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IRobokassaWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IRobokassaWidgetCreator"/>
public static class IRobokassaWidgetCreatorExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="creator"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IRobokassaWidgetCreator.PaymentForm()"/>
  public static string PaymentForm(this IRobokassaWidgetCreator creator, Action<IRobokassaPaymentFormWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.PaymentForm();

    builder(widget);
      
    return widget.ToHtml();
  }
}