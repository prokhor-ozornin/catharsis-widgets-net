using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MailRuFacesWidget : HtmlWidgetBase, IMailRuFacesWidget
  {
    private string backgroundColor;
    private string domain;
    private string font;
    private string frameColor;
    private string height;
    private string hyperlinkColor;
    private bool showTitle = true;
    private string textColor;
    private string title;
    private string titleBackgroundColor;
    private string width;
    
    public IMailRuFacesWidget BackgroundColor(string color)
    {
      Assertion.NotEmpty(color);

      this.backgroundColor = color;
      return this;
    }

    public IMailRuFacesWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    public IMailRuFacesWidget Font(string font)
    {
      Assertion.NotEmpty(font);

      this.font = font;
      return this;
    }

    public IMailRuFacesWidget FrameColor(string color)
    {
      Assertion.NotEmpty(color);

      this.frameColor = color;
      return this;
    }

    public IMailRuFacesWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IMailRuFacesWidget HyperlinkColor(string color)
    {
      Assertion.NotEmpty(color);

      this.hyperlinkColor = color;
      return this;
    }

    public IMailRuFacesWidget ShowTitle(bool show = true)
    {
      this.showTitle = show;
      return this;
    }

    public IMailRuFacesWidget TextColor(string color)
    {
      Assertion.NotEmpty(color);

      this.textColor = color;
      return this;
    }

    public IMailRuFacesWidget Title(string title)
    {
      Assertion.NotEmpty(title);

      this.title = title;
      return this;
    }

    public IMailRuFacesWidget TitleBackgroundColor(string color)
    {
      Assertion.NotEmpty(color);

      this.titleBackgroundColor = color;
      return this;
    }

    public IMailRuFacesWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      throw new NotImplementedException();
    }
  }
}