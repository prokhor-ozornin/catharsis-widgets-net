using System;
using System.IO;
using Catharsis.Commons;
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
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("description"));
      Assert.Null(widget.Field("sum"));
      Assert.True(widget.Field("cards").To<bool>());
      Assert.Equal((byte) YandexMoneyPaymentFormText.Pay, widget.Field("text").To<byte>());
      Assert.False(widget.Field("payerPurpose").To<bool>());
      Assert.False(widget.Field("payerComment").To<bool>());
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.False(widget.Field("payerAddress").To<bool>());
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
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
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
      Assert.Null(widget.Field("description"));
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Field("description").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Null(widget.Field("sum"));
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Field("sum").To<decimal>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Cards(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cards_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.True(widget.Field("cards").To<bool>());
      Assert.True(ReferenceEquals(widget.Cards(false), widget));
      Assert.False(widget.Field("cards").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.Equal((byte)YandexMoneyPaymentFormText.Pay, widget.Field("text").To<byte>());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Field("text").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerPurpose(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPurpose_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerPurpose").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerPurpose(), widget));
      Assert.True(widget.Field("payerPurpose").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerComment(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerComment_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerComment").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerComment(), widget));
      Assert.True(widget.Field("payerComment").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerFullName_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerFullName(), widget));
      Assert.True(widget.Field("payerFullName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerEmail_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerEmail(), widget));
      Assert.True(widget.Field("payerEmail").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerPhone(), widget));
      Assert.True(widget.Field("payerPhone").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.PayerAddress(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerAddress_Method()
    {
      var widget = new YandexMoneyPaymentFormWidget();
      Assert.False(widget.Field("payerAddress").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerAddress(), widget));
      Assert.True(widget.Field("payerAddress").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyPaymentFormWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexMoneyPaymentFormWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexMoneyPaymentFormWidget().Description("description").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexMoneyPaymentFormWidget().Account("account").Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""200"" scrolling=""no"" src=""https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;payment-type-choice=on&amp;writer=seller&amp;targets=description&amp;default-sum=&amp;button-text=01"" width=""450""></iframe>", new StringWriter().With(writer => new YandexMoneyPaymentFormWidget().Account("account").Description("description").Write(writer)).ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""255"" scrolling=""no"" src=""https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;writer=buyer&amp;targets-hint=description&amp;default-sum=1&amp;button-text=03&amp;comment=on&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on"" width=""450""></iframe>", new StringWriter().With(writer => new YandexMoneyPaymentFormWidget().Account("account").Description("description").Sum(1).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).PayerPurpose().PayerComment().PayerFullName().PayerEmail().PayerPhone().PayerAddress().Write(writer)).ToString());
    }
  }
}