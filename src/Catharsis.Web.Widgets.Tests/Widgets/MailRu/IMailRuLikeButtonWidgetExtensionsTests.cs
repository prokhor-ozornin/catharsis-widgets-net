using System;
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

      Assert.Equal("combo", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.All).Type());
      Assert.Equal("mm", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.MailRu).Type());
      Assert.Equal("ok", new MailRuLikeButtonWidget().Type(MailRuLikeButtonType.Odnoklassniki).Type());
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

      Assert.Equal("1", new MailRuLikeButtonWidget().Size(1).Size());
      Assert.Equal("100", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size100).Size());
      Assert.Equal("12", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size12).Size());
      Assert.Equal("150", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size150).Size());
      Assert.Equal("20", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size20).Size());
      Assert.Equal("30", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Size());
      Assert.Equal("45", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size45).Size());
      Assert.Equal("70", new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size70).Size());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Layout(IMailRuLikeButtonWidget, MailRuLikeButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.Layout(null, MailRuLikeButtonLayout.First));

      Assert.Equal(1, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.First).Layout());
      Assert.Equal(2, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Second).Layout());
      Assert.Equal(3, new MailRuLikeButtonWidget().Layout(MailRuLikeButtonLayout.Third).Layout());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.TextType(IMailRuLikeButtonWidget, MailRuLikeButtonTextType)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextType_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.TextType(null, 0));

      Assert.Equal(1, new MailRuLikeButtonWidget().TextType(1).TextType());
      Assert.Equal(1, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.First).TextType());
      Assert.Equal(2, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Second).TextType());
      Assert.Equal(3, new MailRuLikeButtonWidget().TextType(MailRuLikeButtonTextType.Third).TextType());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.CounterPosition(IMailRuLikeButtonWidget, MailRuLikeButtonCounterPosition)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuLikeButtonWidgetExtensions.CounterPosition(null, MailRuLikeButtonCounterPosition.Right));

      Assert.Equal("right", new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Right).CounterPosition());
      Assert.Equal("upper", new MailRuLikeButtonWidget().CounterPosition(MailRuLikeButtonCounterPosition.Upper).CounterPosition());
    }
  }
}