using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class TumblrFollowButtonWidget : HtmlWidgetBase<ITumblrFollowButtonWidget>, ITumblrFollowButtonWidget
  {
    private string account;
    private byte type = (byte) TumblrFollowButtonType.First;
    private string colorScheme = TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant();

    public ITumblrFollowButtonWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public ITumblrFollowButtonWidget Type(byte type)
    {
      this.type = type;
      return this;
    }

    public ITumblrFollowButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      byte width = 189;
      switch ((TumblrFollowButtonType) this.type)
      {
        case TumblrFollowButtonType.Second :
          width = 113;
        break;

        case TumblrFollowButtonType.Third :
          width = 18;
        break;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("border", 0)
        .Attribute("allowtransparency", true)
        .Attribute("src", "http://platform.tumblr.com/v1/follow_button.html?button_type={1}&tumblelog={0}&color_scheme={2}".FormatValue(this.account, this.type, this.colorScheme))
        .Attribute("frameborder", 0)
        .Attribute("height", 25)
        .Attribute("scrolling", "no")
        .Attribute("width", width)
        .AddCssClass("btn")));
    }
  }
}