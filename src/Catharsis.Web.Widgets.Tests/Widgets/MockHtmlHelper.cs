namespace Catharsis.Web.Widgets;

internal sealed class MockHtmlHelper : IHtmlHelper
{
  public MockHtmlHelper() : base(new ViewContext(), new ViewPage())
  {
  }
}