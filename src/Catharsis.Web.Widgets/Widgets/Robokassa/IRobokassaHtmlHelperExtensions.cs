namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IRobokassaHtmlHelper"/>.</para>
/// </summary>
/// <seealso cref="IRobokassaHtmlHelper"/>
public static class IRobokassaHtmlHelperExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IRobokassaHtmlHelper.PaymentForm()"/>
  public static string PaymentForm(this IRobokassaHtmlHelper html, Action<IRobokassaPaymentFormWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.PaymentForm();

    builder(widget);
      
    return widget.ToHtmlString();
  }
}