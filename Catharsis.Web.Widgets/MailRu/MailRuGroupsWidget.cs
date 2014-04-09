using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MailRuGroupsWidget : HtmlWidgetBase, IMailRuGroupsWidget
  {
    private string account;
    private string backgroundColor;
    private string buttonColor;
    private string domain;
    private string height;
    private bool subscribers = true;
    private string textColor;
    private string width;

    public IMailRuGroupsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IMailRuGroupsWidget BackgroundColor(string color)
    {
      Assertion.NotEmpty(color);

      this.backgroundColor = color;
      return this;
    }

    public IMailRuGroupsWidget ButtonColor(string color)
    {
      Assertion.NotEmpty(color);

      this.buttonColor = color;
      return this;
    }

    public IMailRuGroupsWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    public IMailRuGroupsWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IMailRuGroupsWidget Subscribers(bool show = true)
    {
      this.subscribers = show;
      return this;
    }

    public IMailRuGroupsWidget TextColor(string color)
    {
      Assertion.NotEmpty(color);

      this.textColor = color;
      return this;
    }

    public IMailRuGroupsWidget Width(string width)
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