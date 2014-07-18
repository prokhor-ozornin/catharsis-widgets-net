using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CackleLatestCommentsWidget"/>.</para>
  /// </summary>
  public sealed class CackleLatestCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="CackleLatestCommentsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Account());
      Assert.Equal(32, widget.AvatarSize());
      Assert.Equal(5, widget.Max());
      Assert.Equal(150, widget.TextSize());
      Assert.Equal(40, widget.TitleSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleLatestCommentsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new CackleLatestCommentsWidget().Account(string.Empty));

      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.AvatarSize(short)"/> method.</para>
    /// </summary>
    [Fact]
    public void AvatarSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Equal(32, widget.AvatarSize());
      Assert.True(ReferenceEquals(widget.AvatarSize(1), widget));
      Assert.Equal(1, widget.AvatarSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Max(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Max_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Equal(5, widget.Max());
      Assert.True(ReferenceEquals(widget.Max(1), widget));
      Assert.Equal(1, widget.Max());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TextSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Equal(150, widget.TextSize());
      Assert.True(ReferenceEquals(widget.TextSize(1), widget));
      Assert.Equal(1, widget.TextSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TitleSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Equal(40, widget.TitleSize());
      Assert.True(ReferenceEquals(widget.TitleSize(1), widget));
      Assert.Equal(1, widget.TitleSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new CackleLatestCommentsWidget().ToString());

      var html = new CackleLatestCommentsWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<div id=""mc-last""></div>"));
      Assert.True(html.Contains(@"{""widget"":""CommentRecent"",""id"":""account"",""size"":5,""avatarSize"":32,""textSize"":150,""titleSize"":40}"));

      html = new CackleLatestCommentsWidget().Account("account").Max(1).AvatarSize(2).TextSize(3).TitleSize(4).ToString();
      Assert.True(html.Contains(@"<div id=""mc-last""></div>"));
      Assert.True(html.Contains(@"{""widget"":""CommentRecent"",""id"":""account"",""size"":1,""avatarSize"":2,""textSize"":3,""titleSize"":4}"));
    }
  }
}