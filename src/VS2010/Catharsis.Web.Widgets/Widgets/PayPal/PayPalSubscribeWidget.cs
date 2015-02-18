using System;

namespace Catharsis.Web.Widgets
{
  public sealed class PayPalSubscribeWidget : HtmlWidgetBase, IPayPalSubscribeWidget
  {
    public IPayPalSubscribeWidget AsForm()
    {
      throw new NotImplementedException();
    }

    public IPayPalSubscribeWidget AsUrl()
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