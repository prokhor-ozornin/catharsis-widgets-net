using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class TumblrShareButtonWidget : HtmlWidgetBase<ITumblrShareButtonWidget>, ITumblrShareButtonWidget
  {
    private byte type = (byte) TumblrShareButtonType.First;
    private string colorScheme;

    public ITumblrShareButtonWidget Type(byte type)
    {
      this.type = type;
      return this;
    }

    public ITumblrShareButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      byte width;
      switch (this.type.To<TumblrShareButtonType>())
      {
        case TumblrShareButtonType.First :
          width = 80;
        break;

        case TumblrShareButtonType.Second :
          width = 70;
        break;

        case TumblrShareButtonType.Third :
          width = 130;
        break;

        case TumblrShareButtonType.Forth :
          width = 20;
        break;

        default:
          width = 80;
          break;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "http://www.tumblr.com/share")
        .Attribute("title", "Share on Tumblr")
        .Attribute("style", "display:inline-block; text-indent:-9999px; overflow:hidden; width:{2}px; height:20px; background:url('http://platform.tumblr.com/v1/share_{0}{1}.png') top left no-repeat transparent;".FormatValue(this.type, this.colorScheme != null && this.colorScheme.ToLowerInvariant() == TumblrShareButtonColorScheme.Gray.ToString().ToLowerInvariant() ? "T" : string.Empty, width))
        .InnerHtml("Share on Tumblr")));
    }
  }
}