using System;

namespace Catharsis.Web.Widgets
{
  public sealed class PayPalBuyNowWidget : HtmlWidgetBase, IPayPalBuyNowWidget
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    public IPayPalBuyNowWidget AsForm()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    public IPayPalBuyNowWidget AsUrl()
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