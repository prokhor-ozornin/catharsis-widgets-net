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

      Assert.True(new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.All).Field("type").To<string>() == "combo");
      Assert.True(new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.MailRu).Field("type").To<string>() == "mm");
      Assert.True(new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.Odnoklassniki).Field("type").To<string>() == "ok");
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

      Assert.True(new MailRuLikeButtonWidget().Size(1).Field("size").To<string>() == "1");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size100).Field("size").To<string>() == "100");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size12).Field("size").To<string>() == "12");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size150).Field("size").To<string>() == "150");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size20).Field("size").To<string>() == "20");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Field("size").To<string>() == "30");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size45).Field("size").To<string>() == "45");
      Assert.True(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size70).Field("size").To<string>() == "70");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Layout(IMailRuLikeButtonWidget, MailRuLikeButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Layout(null, MailRuLikeButtonLayout.First));

      Assert.True(new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.First).Field("layout").To<byte>() == 1);
      Assert.True(new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Second).Field("layout").To<byte>() == 2);
      Assert.True(new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Third).Field("layout").To<byte>() == 3);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.TextType(IMailRuLikeButtonWidget, MailRuLikeButtonTextType)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextType_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.TextType(null, (byte) 0));

      Assert.True(new MailRuLikeButtonWidget().TextType(1).Field("textType").To<byte>() == 1);
      Assert.True(new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.First).Field("textType").To<byte>() == 1);
      Assert.True(new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Second).Field("textType").To<byte>() == 2);
      Assert.True(new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Third).Field("textType").To<byte>() == 3);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.CounterPosition(IMailRuLikeButtonWidget, MailRuLikeButtonCounterPosition)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.CounterPosition(null, MailRuLikeButtonCounterPosition.Right));

      Assert.True(new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Right).Field("counterPosition").To<string>() == "right");
      Assert.True(new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Upper).Field("counterPosition").To<string>() == "upper");
    }
  }
}