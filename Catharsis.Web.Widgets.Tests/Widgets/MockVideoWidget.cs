namespace Catharsis.Web.Widgets
{
  internal sealed class MockVideoWidget : HtmlWidget, IVideoWidget<MockVideoWidget>
  {
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

    public override string ToHtmlString()
    {
      return string.Empty;
    }
  }
}