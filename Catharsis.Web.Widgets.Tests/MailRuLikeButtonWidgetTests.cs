using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuLikeButtonWidget"/>.</para>
  /// </summary>
  public sealed class MailRuLikeButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="MailRuLikeButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.Equal("combo", widget.Field("type").To<string>());
      Assert.Equal("20", widget.Field("size").To<string>());
      Assert.Equal((byte)MailRuLikeButtonLayout.First, widget.Field("layout").To<byte>());
      Assert.True(widget.Field("text").To<bool>());
      Assert.Equal((byte)MailRuLikeButtonTextType.First, widget.Field("textType").To<byte>());
      Assert.True(widget.Field("counter").To<bool>());
      Assert.Equal(MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant(), widget.Field("counterPosition").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Type(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuLikeButtonWidget().Type(null));
      Assert.Throws<ArgumentException>(() => new MailRuLikeButtonWidget().Type(string.Empty));

      var widget = new MailRuLikeButtonWidget();
      Assert.Equal("combo", widget.Field("type").To<string>());
      Assert.True(ReferenceEquals(widget.Type("type"), widget));
      Assert.Equal("type", widget.Field("type").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.Equal("20", widget.Field("size").To<string>());
      Assert.True(ReferenceEquals(widget.Size("1"), widget));
      Assert.Equal("1", widget.Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Layout(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.Equal((byte)MailRuLikeButtonLayout.First, widget.Field("layout").To<byte>());
      Assert.True(ReferenceEquals(widget.Layout(1), widget));
      Assert.Equal(1, widget.Field("layout").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Text(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("text").To<bool>());
      Assert.True(ReferenceEquals(widget.Text(false), widget));
      Assert.False(widget.Field("text").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.TextType(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextType_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.Equal((byte)MailRuLikeButtonTextType.First, widget.Field("textType").To<byte>());
      Assert.True(ReferenceEquals(widget.TextType(2), widget));
      Assert.Equal(2, widget.Field("textType").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Counter(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Counter_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("counter").To<bool>());
      Assert.True(ReferenceEquals(widget.Counter(false), widget));
      Assert.False(widget.Field("counter").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.CounterPosition(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuLikeButtonWidget().CounterPosition(null));
      Assert.Throws<ArgumentNullException>(() => new MailRuLikeButtonWidget().CounterPosition(null));

      var widget = new MailRuLikeButtonWidget();
      Assert.Equal(MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant(), widget.Field("counterPosition").To<string>());
      Assert.True(ReferenceEquals(widget.CounterPosition("counterPosition"), widget));
      Assert.Equal("counterPosition", widget.Field("counterPosition").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuLikeButtonWidget().Write(null));

      Assert.Equal(@"<a class=""mrc__plugin_uber_like_button"" data-mrc-config=""{&quot;sz&quot;:&quot;20&quot;,&quot;st&quot;:1,&quot;tp&quot;:&quot;combo&quot;,&quot;cm&quot;:1,&quot;ck&quot;:1}"" href=""http://connect.mail.ru/share"" target=""_blank"">Нравится</a>", new StringWriter().With(writer => new MailRuLikeButtonWidget().Write(writer)).ToString());
      Assert.Equal(@"<a class=""mrc__plugin_uber_like_button"" data-mrc-config=""{&quot;sz&quot;:&quot;30&quot;,&quot;st&quot;:2,&quot;tp&quot;:&quot;mm&quot;,&quot;vt&quot;:1,&quot;nt&quot;:1}"" href=""http://connect.mail.ru/share"" target=""_blank"">Нравится</a>", new StringWriter().With(writer => new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Layout(MailRuLikeButtonLayout.Second).Type(MailRuLikeButtonType.MailRu).Counter().CounterPosition(MailRuLikeButtonCounterPosition.Upper).Text(false).Write(writer)).ToString());
    }
  }
}