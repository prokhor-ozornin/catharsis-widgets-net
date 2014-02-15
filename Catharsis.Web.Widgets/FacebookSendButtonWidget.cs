using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookSendButtonWidget : HtmlWidgetBase<IFacebookSendButtonWidget>, IFacebookSendButtonWidget
  {
    private string url;
    private string width;
    private string height;
    private string colorScheme;
    private bool? kids;
    private string trackLabel;

    public IFacebookSendButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookSendButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookSendButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookSendButtonWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookSendButtonWidget Kids(bool kids = true)
    {
      this.kids = kids;
      return this;
    }

    public IFacebookSendButtonWidget TrackLabel(string trackLabel)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = trackLabel;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-kid-directed-site", this.kids)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .Attribute("data-ref", this.trackLabel)
        .AddCssClass("fb-send")));
    }
  }
}