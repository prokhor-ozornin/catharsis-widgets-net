using System.IO;

namespace Catharsis.Web.Widgets
{
  internal sealed class MockVideoWidget : HtmlWidgetBase, IVideoWidget<MockVideoWidget>
  {
    public override void Write(TextWriter writer)
    {
    }

    public MockVideoWidget Id(string id)
    {
      return this;
    }

    public MockVideoWidget Width(string width)
    {
      return this;
    }

    public MockVideoWidget Height(string height)
    {
      return this;
    }
  }
}