namespace Catharsis.Web.Widgets
{
  internal sealed class MockVideoWidget : HtmlWidget, IVideoWidget<MockVideoWidget>
  {
    public MockVideoWidget Id(string id)
    {
      return this;
    }

    public string Id()
    {
      return string.Empty;
    }

    public MockVideoWidget Width(string width)
    {
      return this;
    }

    public string Width()
    {
      return string.Empty;
    }

    public MockVideoWidget Height(string height)
    {
      return this;
    }

    public string Height()
    {
      return string.Empty;
    }

    public override string ToHtmlString()
    {
      return string.Empty;
    }
  }
}