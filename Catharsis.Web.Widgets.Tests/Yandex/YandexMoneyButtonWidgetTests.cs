using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexMoneyButtonWidget"/>.</para>
  /// </summary>
  public sealed class YandexMoneyButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexMoneyButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.Null(widget.Field("account"));
      Assert.Equal("orange",widget.Field("color").To<string>());
      Assert.Null(widget.Field("description"));
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.False(widget.Field("payerAddress").To<bool>());
      Assert.Equal("l", widget.Field("size").To<string>());
      Assert.Null(widget.Field("sum"));
      Assert.Equal((byte)YandexMoneyButtonText.Pay, widget.Field("text").To<byte>());
      Assert.Equal("yamoney-payment-type", widget.Field("type"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Account(string.Empty));

      var widget = new YandexMoneyButtonWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Color(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Color(string.Empty));

      var widget = new YandexMoneyButtonWidget();
      Assert.Equal("orange", widget.Field("color").To<string>());
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.Equal("color", widget.Field("color").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Description(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Description_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Description(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Description(string.Empty));

      var widget = new YandexMoneyButtonWidget();
      Assert.Null(widget.Field("description"));
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Field("description").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.PayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerFullName_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerFullName(), widget));
      Assert.True(widget.Field("payerFullName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.PayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerEmail_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerEmail(), widget));
      Assert.True(widget.Field("payerEmail").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.PayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerPhone(), widget));
      Assert.True(widget.Field("payerPhone").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.PayerAddress(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerAddress_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("payerAddress").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerAddress(), widget));
      Assert.True(widget.Field("payerAddress").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Size(string.Empty));

      var widget = new YandexMoneyButtonWidget();
      Assert.Equal("l", widget.Field("size").To<string>());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.Null(widget.Field("sum"));
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Field("sum").To<decimal>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.Equal((byte) YandexMoneyButtonText.Pay, widget.Field("text").To<byte>());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Field("text").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Type(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Type(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Type(string.Empty));

      var widget = new YandexMoneyButtonWidget();
      Assert.Equal("yamoney-payment-type", widget.Field("type"));
      Assert.True(ReferenceEquals(widget.Type("type"), widget));
      Assert.Equal("type", widget.Field("type").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexMoneyButtonWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexMoneyButtonWidget().Description("description").Sum(1).Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexMoneyButtonWidget().Account("account").Sum(1).Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexMoneyButtonWidget().Account("account").Description("description").Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""54"" scrolling=""no"" src=""https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;yamoney-payment-type=on&amp;button-text=01&amp;button-size=l&amp;button-color=orange&amp;targets=description&amp;default-sum=1"" width=""229""></iframe>", new StringWriter().With(writer => new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Write(writer)).ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""54"" scrolling=""no"" src=""https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;any-card-payment-type=on&amp;button-text=03&amp;button-size=m&amp;button-color=white&amp;targets=description&amp;default-sum=1&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on"" width=""242""></iframe>", new StringWriter().With(writer => new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Transfer).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).PayerFullName().PayerEmail().PayerPhone().PayerAddress().Write(writer)).ToString());
    }
  }
}