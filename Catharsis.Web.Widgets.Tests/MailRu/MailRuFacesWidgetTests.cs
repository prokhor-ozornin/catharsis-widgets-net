using System;
using System.IO;
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
      Assert.Null(widget.Field("domain"));
      Assert.Null(widget.Field("font"));
      Assert.Null(widget.Field("frameColor"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("hyperlinkColor"));
      Assert.True(widget.Field("showTitle").To<bool>());
      Assert.Null(widget.Field("textColor"));
      Assert.Null(widget.Field("title"));
      Assert.Null(widget.Field("titleBackgroundColor"));
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
      Assert.Null(widget.Field("font"));
      Assert.True(ReferenceEquals(widget.Font("font"), widget));
      Assert.Equal("font", widget.Field("font").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.FrameColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void FrameColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().FrameColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().FrameColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Field("frameColor"));
      Assert.True(ReferenceEquals(widget.FrameColor("frameColor"), widget));
      Assert.Equal("frameColor", widget.Field("frameColor").To<string>());
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
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleBackgroundColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleBackgroundColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TitleBackgroundColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TitleBackgroundColor(string.Empty));

      var widget = new MailRuFacesWidget();
      Assert.Null(widget.Field("titleBackgroundColor"));
      Assert.True(ReferenceEquals(widget.TitleBackgroundColor("titleBackgroundColor"), widget));
      Assert.Equal("titleBackgroundColor", widget.Field("titleBackgroundColor").To<string>());
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
    ///   <para>Performs testing of <see cref="MailRuFacesWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Write(null));

      throw new NotImplementedException();
    }
  }
}