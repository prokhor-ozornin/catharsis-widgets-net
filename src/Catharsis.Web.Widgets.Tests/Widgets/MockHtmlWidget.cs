namespace Catharsis.Web.Widgets;

internal sealed class MockHtmlWidget : HtmlWidget
{
  public override string ToHtmlString() => "Widget text content";
}