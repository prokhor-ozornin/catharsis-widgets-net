using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookCommentsWidget : HtmlWidgetBase<IFacebookCommentsWidget>, IFacebookCommentsWidget
  {
    private string url;
    private byte? posts;
    private string width;
    private string colorScheme;
    private bool? mobile;
    private string order;

    public IFacebookCommentsWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookCommentsWidget Posts(byte posts)
    {
      this.posts = posts;
      return this;
    }

    public IFacebookCommentsWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookCommentsWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookCommentsWidget Mobile(bool mobile = true)
    {
      this.mobile = mobile;
      return this;
    }

    public IFacebookCommentsWidget Order(string order)
    {
      Assertion.NotEmpty(order);

      this.order = order;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url)
        .Attribute("data-num-posts", this.posts)
        .Attribute("data-width", this.width)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-mobile", this.mobile)
        .Attribute("data-order-by", this.order)
        .AddCssClass("fb-comments")));
    }
  }
}