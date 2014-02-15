using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookFollowButtonWidget : HtmlWidgetBase<IFacebookFollowButtonWidget>, IFacebookFollowButtonWidget
  {
    private string url;
    private string width;
    private string height;
    private string colorScheme;
    private bool? kids;
    private string layout;
    private bool? faces;

    public IFacebookFollowButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookFollowButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookFollowButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookFollowButtonWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookFollowButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    public IFacebookFollowButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    public IFacebookFollowButtonWidget Faces(bool faces = true)
    {
      this.faces = faces;
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
        .Attribute("data-layout", this.layout)
        .Attribute("data-show-faces", this.faces)
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .AddCssClass("fb-follow")));
    }
  }
}