using System.Web.Mvc;

namespace Catharsis.Web.Widgets
{
  internal sealed class MockHtmlHelper : HtmlHelper
  {
    public MockHtmlHelper() : base(new ViewContext(), new ViewPage())
    {
    }
  }
}