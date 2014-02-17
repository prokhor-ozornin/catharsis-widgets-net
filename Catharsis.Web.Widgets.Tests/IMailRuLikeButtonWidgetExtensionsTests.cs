using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IMailRuLikeButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IMailRuLikeButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Type(IMailRuLikeButtonWidget, MailRuLikeButtonType)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Type(null, MailRuLikeButtonType.All));

      Assert.Equal("combo", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.All).Field("type").To<string>());
      Assert.Equal("mm", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.MailRu).Field("type").To<string>());
      Assert.Equal("ok", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.Odnoklassniki).Field("type").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="IMailRuLikeButtonWidgetExtensions.Size(IMailRuLikeButtonWidget, short)"/></description></item>
    ///     <item><description><see cref="IMailRuLikeButtonWidgetExtensions.Size(IMailRuLikeButtonWidget, MailRuLikeButtonSize)"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void Size_Methods()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Size(null, (short) 0));
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Size(null, MailRuLikeButtonSize.Size100));

      Assert.Equal("1", new MailRuLikeButtonWidget().Size(1).Field("size").To<string>());
      Assert.Equal("100", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size100).Field("size").To<string>());
      Assert.Equal("12", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size12).Field("size").To<string>());
      Assert.Equal("150", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size150).Field("size").To<string>());
      Assert.Equal("20", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size20).Field("size").To<string>());
      Assert.Equal("30", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Field("size").To<string>());
      Assert.Equal("45", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size45).Field("size").To<string>());
      Assert.Equal("70", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size70).Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Layout(IMailRuLikeButtonWidget, MailRuLikeButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Layout(null, MailRuLikeButtonLayout.First));

      Assert.Equal(1, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.First).Field("layout").To<byte>());
      Assert.Equal(2, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Second).Field("layout").To<byte>());
      Assert.Equal(3, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Third).Field("layout").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.TextType(IMailRuLikeButtonWidget, MailRuLikeButtonTextType)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextType_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.TextType(null, 0));

      Assert.Equal(1, new MailRuLikeButtonWidget().TextType(1).Field("textType").To<byte>());
      Assert.Equal(1, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.First).Field("textType").To<byte>());
      Assert.Equal(2, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Second).Field("textType").To<byte>());
      Assert.Equal(3, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Third).Field("textType").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.CounterPosition(IMailRuLikeButtonWidget, MailRuLikeButtonCounterPosition)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.CounterPosition(null, MailRuLikeButtonCounterPosition.Right));

      Assert.Equal("right", new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Right).Field("counterPosition").To<string>());
      Assert.Equal("upper", new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Upper).Field("counterPosition").To<string>());
    }
  }
}