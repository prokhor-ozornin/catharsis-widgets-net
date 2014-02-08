using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class FacebookLikeButtonWidget : HtmlWidgetBase<IFacebookLikeButtonWidget>, IFacebookLikeButtonWidget
  {
    private string verb;
    private string colorScheme;
    private string url;
    private bool? forKids;
    private string layout;
    private string trackLabel;
    private bool? showFaces;
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

    public IFacebookLikeButtonWidget ForKids(bool forKids = true)
    {
      this.forKids = forKids;
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

    public IFacebookLikeButtonWidget ShowFaces(bool show = true)
    {
      this.showFaces = show;
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
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-href", this.url)
        .Attribute("data-kid-directed-site", this.forKids)
        .Attribute("data-layout", this.layout)
        .Attribute("data-ref", this.trackLabel)
        .Attribute("data-show-faces", this.showFaces)
        .Attribute("data-width", this.width)
        .AddCssClass("fb-like")));
    }
  }
}