namespace Catharsis.Web.Widgets;

internal sealed class MockWebWidget : WebWidget
{
  public override string ToHtml() => "Widget text content";
}