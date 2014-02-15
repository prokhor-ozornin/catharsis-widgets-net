using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookRecommendationsFeedWidget : HtmlWidgetBase<IFacebookRecommendationsFeedWidget>, IFacebookRecommendationsFeedWidget
  {
    private string domain;
    private string appId;
    private IEnumerable<string> actions = Enumerable.Empty<string>();
    private string width;
    private string height;
    private string colorScheme;
    private bool? header;
    private string linkTarget;
    private byte? maxAge;
    private string trackLabel;

    public IFacebookRecommendationsFeedWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    public IFacebookRecommendationsFeedWidget AppId(string appId)
    {
      Assertion.NotEmpty(appId);

      this.appId = appId;
      return this;
    }

    public IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
    {
      Assertion.NotNull(actions);

      this.actions = actions;
      return this;
    }

    public IFacebookRecommendationsFeedWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookRecommendationsFeedWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookRecommendationsFeedWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookRecommendationsFeedWidget Header(bool header = true)
    {
      this.header = header;
      return this;
    }

    public IFacebookRecommendationsFeedWidget LinkTarget(string linkTarget)
    {
      Assertion.NotEmpty(linkTarget);

      this.linkTarget = linkTarget;
      return this;
    }

    public IFacebookRecommendationsFeedWidget MaxAge(byte maxAge)
    {
      this.maxAge = maxAge;
      return this;
    }

    public IFacebookRecommendationsFeedWidget TrackLabel(string trackLabel)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = trackLabel;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-site", this.domain)
        .Attribute("data-app-id", this.appId)
        .Attribute("data-action", this.actions.Any() ? this.actions.Join(",") : null)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-header", this.header)
        .Attribute("data-linktarget", this.linkTarget)
        .Attribute("data-max-age", this.maxAge)
        .Attribute("data-ref", this.trackLabel)
        .AddCssClass("fb-recommendations")));
    }
  }
}