using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookLikeButtonWidget : HtmlWidgetBase<IFacebookLikeButtonWidget>, IFacebookLikeButtonWidget
  {
    private string verb;
    private string colorScheme;
    private string url;
    private bool? kids;
    private string layout;
    private string trackLabel;
    private bool? faces;
    private string width;

    public IFacebookLikeButtonWidget Verb(string verb)
    {
      Assertion.NotEmpty(verb);

      this.verb = verb;
      return this;
    }

    public IFacebookLikeButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    public IFacebookLikeButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookLikeButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    public IFacebookLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    public IFacebookLikeButtonWidget TrackLabel(string trackLabel)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = trackLabel;
      return this;
    }

    public IFacebookLikeButtonWidget Faces(bool faces = true)
    {
      this.faces = faces;
      return this;
    }

    public IFacebookLikeButtonWidget Width(string width)
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
        .Attribute("data-action", this.verb)
        .Attribute("data-layout", this.layout)
        .Attribute("data-show-faces", this.faces)
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-ref", this.trackLabel)
        .Attribute("data-width", this.width)
        .AddCssClass("fb-like")));
    }
  }
}