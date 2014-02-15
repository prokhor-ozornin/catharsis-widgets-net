using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookFacepileWidget : HtmlWidgetBase<IFacebookFacepileWidget>, IFacebookFacepileWidget
  {
    private string url;
    private IEnumerable<string> actions = Enumerable.Empty<string>();
    private string size;
    private string width;
    private string height;
    private byte? maxRows;
    private string colorScheme;

    public IFacebookFacepileWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IFacebookFacepileWidget Actions(IEnumerable<string> actions)
    {
      Assertion.NotNull(actions);

      this.actions = actions;
      return this;
    }

    public IFacebookFacepileWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    public IFacebookFacepileWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookFacepileWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookFacepileWidget MaxRows(byte maxRows)
    {
      this.maxRows = maxRows;
      return this;
    }

    public IFacebookFacepileWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url ?? (HttpContext.Current != null ? HttpContext.Current.Request.Url.ToString() : null))
        .Attribute("data-action", this.actions.Any() ? this.actions.Join(",") : null)
        .Attribute("data-size", this.size)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .Attribute("data-max-rows", this.maxRows)
        .Attribute("data-colorscheme", this.colorScheme)
        .AddCssClass("fb-facepile")));
    }
  }
}