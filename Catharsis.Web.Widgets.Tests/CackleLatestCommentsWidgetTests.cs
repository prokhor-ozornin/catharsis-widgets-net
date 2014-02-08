using System;
using System.IO;
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
    ///   <seealso cref="CackleLatestCommentsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(widget.Field("max") == null);
      Assert.True(widget.Field("textSize") == null);
      Assert.True(widget.Field("titleSize") == null);
      Assert.True(widget.Field("avatarSize") == null);
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
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Max(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Max_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.True(widget.Field("max") == null);
      Assert.True(ReferenceEquals(widget.Max(1), widget));
      Assert.True(widget.Field("max").To<byte>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TextSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.True(widget.Field("textSize") == null);
      Assert.True(ReferenceEquals(widget.TextSize(1), widget));
      Assert.True(widget.Field("textSize").To<int>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TitleSize(int)"/> method.</para>
    /// </summary>
    [Fact]
    public void TitleSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.True(widget.Field("titleSize") == null);
      Assert.True(ReferenceEquals(widget.TitleSize(1), widget));
      Assert.True(widget.Field("titleSize").To<int>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.AvatarSize(short)"/> method.</para>
    /// </summary>
    [Fact]
    public void AvatarSize_Method()
    {
      var widget = new CackleLatestCommentsWidget();
      Assert.True(widget.Field("avatarSize") == null);
      Assert.True(ReferenceEquals(widget.AvatarSize(1), widget));
      Assert.True(widget.Field("avatarSize").To<short>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleLatestCommentsWidget().Write(null));

      Assert.True(new StringWriter().With(new CackleLatestCommentsWidget().Write).ToString().IsEmpty());

      new StringWriter().With(writer =>
      {
        new CackleLatestCommentsWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""mc-last""></div>"));
        Assert.True(html.Contains(@"{""widget"":""CommentRecent"",""id"":""account"",""size"":5,""avatarSize"":32,""textSize"":150,""titleSize"":40}"));
      });

      new StringWriter().With(writer =>
      {
        new CackleLatestCommentsWidget().Account("account").Max(1).AvatarSize(2).TextSize(3).TitleSize(4).Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""mc-last""></div>"));
        Assert.True(html.Contains(@"{""widget"":""CommentRecent"",""id"":""account"",""size"":1,""avatarSize"":2,""textSize"":3,""titleSize"":4}"));
      });
    }
  }
}