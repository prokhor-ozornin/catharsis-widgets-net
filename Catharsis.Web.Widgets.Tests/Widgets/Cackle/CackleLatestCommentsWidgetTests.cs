using System;
using Catharsis.Commons;
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
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("avatarSize"));
      Assert.Null(widget.Field("max"));
      Assert.Null(widget.Field("textSize"));
      Assert.Null(widget.Field("titleSize"));
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
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.AvatarSize(short)"/> method.</para>
    /// </summary>
    [Fact]
    public void AvatarSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Field("avatarSize"));
      Assert.True(ReferenceEquals(widget.AvatarSize(1), widget));
      Assert.Equal(1, widget.Field("avatarSize").To<short>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Max(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Max_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Field("max"));
      Assert.True(ReferenceEquals(widget.Max(1), widget));
      Assert.Equal(1, widget.Field("max").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TextSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Field("textSize"));
      Assert.True(ReferenceEquals(widget.TextSize(1), widget));
      Assert.Equal(1, widget.Field("textSize").To<int>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TitleSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.Null(widget.Field("titleSize"));
      Assert.True(ReferenceEquals(widget.TitleSize(1), widget));
      Assert.Equal(1, widget.Field("titleSize").To<int>());
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