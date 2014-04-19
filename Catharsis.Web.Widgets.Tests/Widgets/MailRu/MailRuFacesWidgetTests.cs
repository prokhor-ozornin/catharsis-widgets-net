using System;
using Catharsis.Commons;
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
      Assert.Null(widget.Field("backgroundColor"));
      Assert.Null(widget.Field("borderColor"));
      Assert.Null(widget.Field("domain"));
      Assert.Equal(MailRuFacesFont.Arial.ToString(), widget.Field("font").To<string>());
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("hyperlinkColor"));
      Assert.True(widget.Field("showTitle").To<bool>());
      Assert.Null(widget.Field("textColor"));
      Assert.Null(widget.Field("title"));
      Assert.Null(widget.Field("titleColor"));
      Assert.Null(widget.Field("width"));
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
      Assert.Null(widget.Field("backgroundColor"));
      Assert.True(ReferenceEquals(widget.BackgroundColor("backgroundColor"), widget));
      Assert.Equal("backgroundColor", widget.Field("backgroundColor").To<string>());
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
      Assert.Null(widget.Field("borderColor"));
      Assert.True(ReferenceEquals(widget.BorderColor("borderColor"), widget));
      Assert.Equal("borderColor", widget.Field("borderColor").To<string>());
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
      Assert.Null(widget.Field("domain"));
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Field("domain").To<string>());
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
      Assert.Equal(MailRuFacesFont.Arial.ToString(), widget.Field("font").To<string>());
      Assert.True(ReferenceEquals(widget.Font("font"), widget));
      Assert.Equal("font", widget.Field("font").To<string>());
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
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
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
      Assert.Null(widget.Field("hyperlinkColor"));
      Assert.True(ReferenceEquals(widget.HyperlinkColor("hyperlinkColor"), widget));
      Assert.Equal("hyperlinkColor", widget.Field("hyperlinkColor").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.ShowTitle(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowTitle_Method()
    {
      var widget = new MailRuFacesWidget();
      Assert.True(widget.Field("showTitle").To<bool>());
      Assert.True(ReferenceEquals(widget.ShowTitle(false), widget));
      Assert.False(widget.Field("showTitle").To<bool>());
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
      Assert.Null(widget.Field("textColor"));
      Assert.True(ReferenceEquals(widget.TextColor("textColor"), widget));
      Assert.Equal("textColor", widget.Field("textColor").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Title(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Title_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Title(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Title(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Field("title"));
      Assert.True(ReferenceEquals(widget.Title("title"), widget));
      Assert.Equal("title", widget.Field("title").To<string>());
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
      Assert.Null(widget.Field("titleColor"));
      Assert.True(ReferenceEquals(widget.TitleColor("titleColor"), widget));
      Assert.Equal("titleColor", widget.Field("titleColor").To<string>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
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
      Assert.Equal(@"<a class=""mrc__plugin_share_friends"" href=""http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height&amp;title=title&amp;notitle=true&amp;title-color=titleColor&amp;background=backgroundColor&amp;border=borderColor&amp;color=textColor&amp;link-color=hyperlinkColor"" rel=""{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;title&quot;:&quot;title&quot;,&quot;notitle&quot;:true,&quot;title-color&quot;:&quot;titleColor&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;border&quot;:&quot;borderColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;link-color&quot;:&quot;hyperlinkColor&quot;}"">Друзья</a>", new MailRuFacesWidget().Domain("domain").Width("width").Height("height").Title("title").ShowTitle(false).TitleColor("titleColor").BackgroundColor("backgroundColor").BorderColor("borderColor").TextColor("textColor").HyperlinkColor("hyperlinkColor").ToString());
    }
  }
}