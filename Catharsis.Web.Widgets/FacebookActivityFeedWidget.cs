using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookActivityFeedWidget : HtmlWidgetBase<IFacebookActivityFeedWidget>, IFacebookActivityFeedWidget
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
    private bool? recommendations;
    private string trackLabel;

    public IFacebookActivityFeedWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    public IFacebookActivityFeedWidget AppId(string appId)
    {
      Assertion.NotEmpty(appId);

      this.appId = appId;
      return this;
    }

    public IFacebookActivityFeedWidget Actions(IEnumerable<string> actions)
    {
      Assertion.NotNull(actions);

      this.actions = actions;
      return this;
    }

    public IFacebookActivityFeedWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IFacebookActivityFeedWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IFacebookActivityFeedWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    public IFacebookActivityFeedWidget Header(bool header = true)
    {
      this.header = header;
      return this;
    }

    public IFacebookActivityFeedWidget LinkTarget(string linkTarget)
    {
      Assertion.NotEmpty(linkTarget);

      this.linkTarget = linkTarget;
      return this;
    }

    public IFacebookActivityFeedWidget MaxAge(byte maxAge)
    {
      this.maxAge = maxAge;
      return this;
    }

    public IFacebookActivityFeedWidget Recommendations(bool recommendations = true)
    {
      this.recommendations = recommendations;
      return this;
    }

    public IFacebookActivityFeedWidget TrackLabel(string trackLabel)
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
        .Attribute("data-recommendations", this.recommendations)
        .Attribute("data-ref", this.trackLabel)
        .AddCssClass("fb-activity")));
    }
  }
}