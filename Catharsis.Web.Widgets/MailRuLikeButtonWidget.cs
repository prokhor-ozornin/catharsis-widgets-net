using System;
using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru "Like" button on web page.</para>
  ///   <para>Requires <see cref="WidgetsScripts.MailRuLike"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/share"/>
  public sealed class MailRuLikeButtonWidget : HtmlWidgetBase<IMailRuLikeButtonWidget>, IMailRuLikeButtonWidget
  {
    private string type = "combo";
    private string size = "20";
    private byte layout = (byte) MailRuLikeButtonLayout.First;
    private bool text = true;
    private byte textType = (byte) MailRuLikeButtonTextType.First;
    private bool counter = true;
    private string counterPosition = MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant();

    /// <summary>
    ///   <para>Type of button.</para>
    /// </summary>
    /// <param name="type">Type of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget Type(string type)
    {
      Assertion.NotEmpty(type);

      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Size(string size)
    {
      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="layout">Visual layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget Layout(byte layout)
    {
      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="text"><c>true</c> to show text label, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Text(bool text = true)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <param name="type">Type of text label.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget TextType(byte type)
    {
      this.textType = type;
      return this;
    }

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="counter"><c>true</c> to show share counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Counter(bool counter = true)
    {
      this.counter = counter;
      return this;
    }

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <param name="position">Position of a counter.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget CounterPosition(string position)
    {
      Assertion.NotEmpty(position);

      this.counterPosition = position;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "sz", this.size }, { "st", this.layout }, { "tp", this.type } };
      
      if (!this.counter)
      {
        config["nc"] = 1;
      }
      else if (this.counterPosition != null && this.counterPosition.ToLowerInvariant() == MailRuLikeButtonCounterPosition.Upper.ToString().ToLowerInvariant())
      {
        config["vt"] = 1;
      }

      if (!this.text)
      {
        config["nt"] = 1;
      }
      else
      {
        config["cm"] = this.textType;
        config["ck"] = this.textType;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("target", "_blank")
        .Attribute("href", "http://connect.mail.ru/share")
        .Attribute("data-mrc-config", config.Json())
        .InnerHtml("Нравится")
        .AddCssClass("mrc__plugin_uber_like_button")));

    }
  }
}