using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexMoneyPaymentFormWidget"/>.</para>
  /// </summary>
  public sealed class YandexMoneyPaymentFormWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexMoneyPaymentFormWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Null(widget.Account());
      Assert.Null(widget.Description());
      Assert.Null(widget.Sum());
      Assert.True(widget.Cards());
      Assert.Equal((byte) YandexMoneyPaymentFormText.Pay, widget.Text());
      Assert.False(widget.AskPayerPurpose());
      Assert.False(widget.AskPayerComment());
      Assert.False(widget.AskPayerFullName());
      Assert.False(widget.AskPayerEmail());
      Assert.False(widget.AskPayerPhone());
      Assert.False(widget.AskPayerAddress());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyPaymentFormWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyPaymentFormWidget().Account(string.Empty));

      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Description(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Description_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyPaymentFormWidget().Description(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyPaymentFormWidget().Description(string.Empty));

      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Null(widget.Description());
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Description());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Null(widget.Sum());
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Sum());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Cards(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cards_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.True(widget.Cards());
      Assert.True(ReferenceEquals(widget.Cards(false), widget));
      Assert.False(widget.Cards());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Equal((byte)YandexMoneyPaymentFormText.Pay, widget.Text());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Text());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerPurpose_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerPurpose());
      Assert.True(ReferenceEquals(widget.AskPayerPurpose(true), widget));
      Assert.True(widget.AskPayerPurpose());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerComment(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerComment_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerComment());
      Assert.True(ReferenceEquals(widget.AskPayerComment(true), widget));
      Assert.True(widget.AskPayerComment());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerFullName_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerFullName());
      Assert.True(ReferenceEquals(widget.AskPayerFullName(true), widget));
      Assert.True(widget.AskPayerFullName());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerEmail_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerEmail());
      Assert.True(ReferenceEquals(widget.AskPayerEmail(true), widget));
      Assert.True(widget.AskPayerEmail());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerPhone());
      Assert.True(ReferenceEquals(widget.AskPayerPhone(true), widget));
      Assert.True(widget.AskPayerPhone());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerAddress_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.AskPayerAddress());
      Assert.True(ReferenceEquals(widget.AskPayerAddress(true), widget));
      Assert.True(widget.AskPayerAddress());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().ToString());
      Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().Description("description").ToString());
      Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().Account("account").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""200"" scrolling=""no"" src=""https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;payment-type-choice=on&amp;writer=seller&amp;targets=description&amp;default-sum=&amp;button-text=01"" width=""450""></iframe>", new YandexMoneyPaymentFormWidget().Account("account").Description("description").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""255"" scrolling=""no"" src=""https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;writer=buyer&amp;targets-hint=description&amp;default-sum=1&amp;button-text=03&amp;comment=on&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on"" width=""450""></iframe>", new YandexMoneyPaymentFormWidget().Account("account").Description("description").Sum(1).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).AskPayerPurpose(true).AskPayerComment(true).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true).ToString());
    }
  }
}