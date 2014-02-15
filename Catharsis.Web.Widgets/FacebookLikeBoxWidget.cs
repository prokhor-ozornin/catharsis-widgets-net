using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookLikeBoxWidget : HtmlWidgetBase<IFacebookLikeBoxWidget>, IFacebookLikeBoxWidget
  {
    private string url;
    private string width;
    private string height;
    private string colorScheme;
    private bool? wall;
    private bool? header;
    private bool? border;
    private bool? faces;
    private bool? stream;

    public IFacebookLikeBoxWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookLikeBoxWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookLikeBoxWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookLikeBoxWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookLikeBoxWidget Wall(bool wall = true)
    {
      this.wall = wall;
      return this;
    }

    public IFacebookLikeBoxWidget Header(bool header = true)
    {
      this.header = header;
      return this;
    }

    public IFacebookLikeBoxWidget Border(bool border = true)
    {
      this.border = border;
      return this;
    }

    public IFacebookLikeBoxWidget Faces(bool faces = true)
    {
      this.faces = faces;
      return this;
    }

    public IFacebookLikeBoxWidget Stream(bool stream = true)
    {
      this.stream = stream;
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
        .Attribute("data-height", this.height)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-force-wall", this.wall)
        .Attribute("data-header", this.header)
        .Attribute("data-show-border", this.border)
        .Attribute("data-show-faces", this.faces)
        .Attribute("data-stream", this.stream)
        .AddCssClass("fb-like-box")));
    }
  }
}