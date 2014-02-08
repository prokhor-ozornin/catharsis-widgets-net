namespace Catharsis.Web.Widgets
{
  internal sealed class SurfingbirdHtmlHelper : ISurfingbirdHtmlHelper
  {
    public ISurfingbirdSurfButtonWidget Surf()
    {
      return new SurfingbirdSurfButtonWidget();
    }
  }
}