using System;
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
      Assert.False(widget.Field("askPayerFullName").To<bool>());
      Assert.False(widget.Field("askPayerEmail").To<bool>());
      Assert.False(widget.Field("askPayerPhone").To<bool>());
      Assert.False(widget.Field("askPayerAddress").To<bool>());
      Assert.Equal("orange", widget.Field("color").To<string>());
      Assert.Null(widget.Field("description"));
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
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerFullName_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("askPayerFullName").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerFullName(), widget));
      Assert.True(widget.Field("askPayerFullName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerEmail_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("askPayerEmail").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerEmail(), widget));
      Assert.True(widget.Field("askPayerEmail").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("askPayerPhone").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerPhone(), widget));
      Assert.True(widget.Field("askPayerPhone").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerAddress(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerAddress_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.Field("askPayerAddress").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerAddress(), widget));
      Assert.True(widget.Field("askPayerAddress").To<bool>());
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
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexMoneyButtonWidget().ToString());
      Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Description("description").Sum(1).ToString());
      Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Account("account").Sum(1).ToString());
      Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Account("account").Description("description").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""54"" scrolling=""no"" src=""https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;yamoney-payment-type=on&amp;button-text=01&amp;button-size=l&amp;button-color=orange&amp;targets=description&amp;default-sum=1"" width=""229""></iframe>", new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""54"" scrolling=""no"" src=""https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;any-card-payment-type=on&amp;button-text=03&amp;button-size=m&amp;button-color=white&amp;targets=description&amp;default-sum=1&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on"" width=""242""></iframe>", new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Transfer).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).AskPayerFullName().AskPayerEmail().AskPayerPhone().AskPayerAddress().ToString());
    }
  }
}