using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuFacesWidget"/>.</para>
  /// </summary>
  public sealed class MailRuFacesWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuFacesWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuFacesWidget();
      Assert.Null(widget.BackgroundColor());
      Assert.Null(widget.BorderColor());
      Assert.Null(widget.Domain());
      Assert.Equal(MailRuFacesFont.Arial.ToString(), widget.Font());
      Assert.Null(widget.Height());
      Assert.Null(widget.HyperlinkColor());
      Assert.Null(widget.TextColor());
      Assert.True(widget.Title());
      Assert.Null(widget.TitleColor());
      Assert.Null(widget.TitleText());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.BackgroundColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void BackgroundColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().BackgroundColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().BackgroundColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.BackgroundColor());
      Assert.True(ReferenceEquals(widget.BackgroundColor("backgroundColor"), widget));
      Assert.Equal("backgroundColor", widget.BackgroundColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.BorderColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void BorderColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().BorderColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().BorderColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.BorderColor());
      Assert.True(ReferenceEquals(widget.BorderColor("borderColor"), widget));
      Assert.Equal("borderColor", widget.BorderColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Domain(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Domain());
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Domain());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Font(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Font_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Font(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Font(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Equal(MailRuFacesFont.Arial.ToString(), widget.Font());
      Assert.True(ReferenceEquals(widget.Font("font"), widget));
      Assert.Equal("font", widget.Font());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Height(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.HyperlinkColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void HyperlinkColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().HyperlinkColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().HyperlinkColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.HyperlinkColor());
      Assert.True(ReferenceEquals(widget.HyperlinkColor("hyperlinkColor"), widget));
      Assert.Equal("hyperlinkColor", widget.HyperlinkColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.TextColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TextColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TextColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.TextColor());
      Assert.True(ReferenceEquals(widget.TextColor("textColor"), widget));
      Assert.Equal("textColor", widget.TextColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Title(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Title_Method()
    {
      var widget = new MailRuFacesWidget();
      Assert.True(widget.Title());
      Assert.True(ReferenceEquals(widget.Title(false), widget));
      Assert.False(widget.Title());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TitleColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TitleColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.TitleColor());
      Assert.True(ReferenceEquals(widget.TitleColor("titleColor"), widget));
      Assert.Equal("titleColor", widget.TitleColor());
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleText(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleText_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TitleText(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TitleText(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.TitleText());
      Assert.True(ReferenceEquals(widget.TitleText("titleText"), widget));
      Assert.Equal("titleText", widget.TitleText());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Width(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new MailRuFacesWidget().ToString());
      Assert.Equal(string.Empty, new MailRuFacesWidget().Domain("domain").Width("width").ToString());
      Assert.Equal(string.Empty, new MailRuFacesWidget().Domain("domain").Height("height").ToString());
      Assert.Equal(string.Empty, new MailRuFacesWidget().Width("width").Height("height").ToString());
      Assert.Equal(@"<a class=""mrc__plugin_share_friends"" href=""http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height"" rel=""{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}"">Друзья</a>", new MailRuFacesWidget().Domain("domain").Width("width").Height("height").ToString());
      Assert.Equal(@"<a class=""mrc__plugin_share_friends"" href=""http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height&amp;title=title&amp;notitle=true&amp;title-color=titleColor&amp;background=backgroundColor&amp;border=borderColor&amp;color=textColor&amp;link-color=hyperlinkColor"" rel=""{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;title&quot;:&quot;title&quot;,&quot;notitle&quot;:true,&quot;title-color&quot;:&quot;titleColor&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;border&quot;:&quot;borderColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;link-color&quot;:&quot;hyperlinkColor&quot;}"">Друзья</a>", new MailRuFacesWidget().Domain("domain").Width("width").Height("height").TitleText("title").Title(false).TitleColor("titleColor").BackgroundColor("backgroundColor").BorderColor("borderColor").TextColor("textColor").HyperlinkColor("hyperlinkColor").ToString());
    }
  }
}