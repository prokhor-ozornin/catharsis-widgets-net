using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class FacebookPostWidget : HtmlWidgetBase<IFacebookPostWidget>, IFacebookPostWidget
  {
    private string url;
    private string width;
    
    public IFacebookPostWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookPostWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.url.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url)
        .Attribute("data-width", this.width)
        .AddCssClass("fb-post")));
    }
  }
}