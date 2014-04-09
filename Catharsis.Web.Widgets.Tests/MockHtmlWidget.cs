using System.IO;

namespace Catharsis.Web.Widgets
{
  internal sealed class MockHtmlWidget : HtmlWidgetBase
  {
    public const string Contents = "Widget text content";

    public override void Write(TextWriter writer)
    {
      writer.Write(Contents);
    }
  }
}