using System;
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
      Assert.Null(widget.Account());
      Assert.False(widget.AskPayerFullName());
      Assert.False(widget.AskPayerEmail());
      Assert.False(widget.AskPayerPhone());
      Assert.False(widget.AskPayerAddress());
      Assert.Equal("orange", widget.Color());
      Assert.Null(widget.Description());
      Assert.Equal("l", widget.Size());
      Assert.Null(widget.Sum());
      Assert.Equal((byte) YandexMoneyButtonText.Pay, widget.Text());
      Assert.Equal("yamoney-payment-type", widget.Type());
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
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
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
      Assert.Equal("orange", widget.Color());
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.Equal("color", widget.Color());
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
      Assert.Null(widget.Description());
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Description());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerFullName_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.AskPayerFullName());
      Assert.True(ReferenceEquals(widget.AskPayerFullName(true), widget));
      Assert.True(widget.AskPayerFullName());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerEmail_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.AskPayerEmail());
      Assert.True(ReferenceEquals(widget.AskPayerEmail(true), widget));
      Assert.True(widget.AskPayerEmail());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.AskPayerPhone());
      Assert.True(ReferenceEquals(widget.AskPayerPhone(true), widget));
      Assert.True(widget.AskPayerPhone());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerAddress(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerAddress_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.False(widget.AskPayerAddress());
      Assert.True(ReferenceEquals(widget.AskPayerAddress(true), widget));
      Assert.True(widget.AskPayerAddress());
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
      Assert.Equal("l", widget.Size());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Size());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.Null(widget.Sum());
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Sum());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyButtonWidget();
      Assert.Equal((byte) YandexMoneyButtonText.Pay, widget.Text());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Text());
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
      Assert.Equal("yamoney-payment-type", widget.Type());
      Assert.True(ReferenceEquals(widget.Type("type"), widget));
      Assert.Equal("type", widget.Type());
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
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""54"" scrolling=""no"" src=""https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;any-card-payment-type=on&amp;button-text=03&amp;button-size=m&amp;button-color=white&amp;targets=description&amp;default-sum=1&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on"" width=""242""></iframe>", new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Transfer).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true).ToString());
    }
  }
}