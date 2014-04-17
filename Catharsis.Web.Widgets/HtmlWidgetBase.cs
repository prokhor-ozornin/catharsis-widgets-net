namespace Catharsis.Web.Widgets
{
  public abstract class HtmlWidgetBase : IHtmlWidget
  {
    public abstract string ToHtmlString();

    public override string ToString()
    {
      return this.ToHtmlString();
    }
  }
}