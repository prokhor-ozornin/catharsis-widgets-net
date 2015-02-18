using System;

namespace Catharsis.Web.Widgets
{
  public sealed class PayPalBuyGiftCertificateWidget : HtmlWidgetBase, IPayPalBuyGiftCertificateWidget
  {
    public IPayPalBuyGiftCertificateWidget AsForm()
    {
      throw new NotImplementedException();
    }

    public IPayPalBuyGiftCertificateWidget AsUrl()
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