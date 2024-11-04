using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class PayPalDonateWidget : HtmlWidgetBase, IPayPalDonateWidget
  {
    public IPayPalDonateWidget AsForm()
    {
      throw new NotImplementedException();
    }

    public IPayPalDonateWidget AsUrl()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      throw new NotImplementedException();
    }
  }
}