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
      Assert.True(widget.Field("type").To<string>() == "combo");
      Assert.True(widget.Field("size").To<string>() == "20");
      Assert.True(widget.Field("layout").To<byte>() == (byte) MailRuLikeButtonLayout.First);
      Assert.True(widget.Field("hasText").To<bool>());
      Assert.True(widget.Field("textType").To<byte>() == (byte) MailRuLikeButtonTextType.First);
      Assert.True(widget.Field("hasCounter").To<bool>());
      Assert.True(widget.Field("counterPosition").To<string>() == MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant());
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
      Assert.True(widget.Field("type").To<string>() == "combo");
      Assert.True(ReferenceEquals(widget.Type("type"), widget));
      Assert.True(widget.Field("type").To<string>() == "type");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("size").To<string>() == "20");
      Assert.True(ReferenceEquals(widget.Size("1"), widget));
      Assert.True(widget.Field("size").To<string>() == "1");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Layout(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("layout").To<byte>() == (byte) MailRuLikeButtonLayout.First);
      Assert.True(ReferenceEquals(widget.Layout(1), widget));
      Assert.True(widget.Field("layout").To<byte>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.HasText(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void HasText_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("hasText").To<bool>());
      Assert.True(ReferenceEquals(widget.HasText(false), widget));
      Assert.False(widget.Field("hasText").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.TextType(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextType_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("textType").To<byte>() == (byte)MailRuLikeButtonTextType.First);
      Assert.True(ReferenceEquals(widget.TextType(2), widget));
      Assert.True(widget.Field("textType").To<byte>() == 2);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.HasCounter(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void HasCounter_Method()
    {
      var widget = new MailRuLikeButtonWidget();
      Assert.True(widget.Field("hasCounter").To<bool>());
      Assert.True(ReferenceEquals(widget.HasCounter(false), widget));
      Assert.False(widget.Field("hasCounter").To<bool>());
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
      Assert.True(widget.Field("counterPosition").To<string>() == MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant());
      Assert.True(ReferenceEquals(widget.CounterPosition("counterPosition"), widget));
      Assert.True(widget.Field("counterPosition").To<string>() == "counterPosition");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuLikeButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new MailRuLikeButtonWidget().Write(writer)).ToString() == @"<a class=""mrc__plugin_uber_like_button"" data-mrc-config=""{&quot;sz&quot;:&quot;20&quot;,&quot;st&quot;:1,&quot;tp&quot;:&quot;combo&quot;,&quot;cm&quot;:1,&quot;ck&quot;:1}"" href=""http://connect.mail.ru/share"" target=""_blank"">Нравится</a>");
      Assert.True(new StringWriter().With(writer => new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Layout(MailRuLikeButtonLayout.Second).Type(MailRuLikeButtonType.MailRu).HasCounter().CounterPosition(MailRuLikeButtonCounterPosition.Upper).HasText(false).Write(writer)).ToString() == @"<a class=""mrc__plugin_uber_like_button"" data-mrc-config=""{&quot;sz&quot;:&quot;30&quot;,&quot;st&quot;:2,&quot;tp&quot;:&quot;mm&quot;,&quot;vt&quot;:1,&quot;nt&quot;:1}"" href=""http://connect.mail.ru/share"" target=""_blank"">Нравится</a>");
    }
  }
}