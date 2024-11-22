namespace Catharsis.Web.Widgets.Tests;

internal sealed class MockWebWidget : WebWidget
{
  public override string ToHtml() => "Widget text content";
}