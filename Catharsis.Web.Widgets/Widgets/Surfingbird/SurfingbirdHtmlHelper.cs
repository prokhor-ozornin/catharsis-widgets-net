namespace Catharsis.Web.Widgets
{
  internal sealed class SurfingbirdHtmlHelper : ISurfingbirdHtmlHelper
  {
    public ISurfingbirdSurfButtonWidget SurfButton()
    {
      return new SurfingbirdSurfButtonWidget();
    }
  }
}