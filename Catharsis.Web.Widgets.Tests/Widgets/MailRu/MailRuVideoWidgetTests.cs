using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuVideoWidget"/>.</para>
  /// </summary>
  public sealed class MailRuVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuVideoWidget();
      Assert.Null(widget.Id());
      Assert.Null(widget.Height());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Id(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.Null(widget.Id());
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Id());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Width(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Height(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new MailRuVideoWidget().ToString());
      Assert.Equal(string.Empty, new MailRuVideoWidget().Id("id").Height("height").ToString());
      Assert.Equal(string.Empty, new MailRuVideoWidget().Id("id").Width("width").ToString());
      Assert.Equal(string.Empty, new MailRuVideoWidget().Height("height").Width("width").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://api.video.mail.ru/videos/embed/mail/id"" webkitallowfullscreen=""true"" width=""width""></iframe>", new MailRuVideoWidget().Id("id").Height("height").Width("width").ToString());
    }
  }
}