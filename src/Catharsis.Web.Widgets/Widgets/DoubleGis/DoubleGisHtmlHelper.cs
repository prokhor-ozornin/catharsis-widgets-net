namespace Catharsis.Web.Widgets
{
  internal sealed class DoubleGisHtmlHelper : IDoubleGisHtmlHelper
  {
    public IDoubleGisContactsMapWidget ContactsMap()
    {
      return new DoubleGisContactsMapWidget();
    }

    public IDoubleGisMapWidget Map()
    {
      return new DoubleGisMapWidget();
    }

    public IDoubleGisMiniMapWidget MiniMap()
    {
      return new DoubleGisMiniMapWidget();
    }
  }
}