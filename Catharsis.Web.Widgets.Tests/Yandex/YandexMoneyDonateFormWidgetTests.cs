using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexMoneyDonateFormWidget"/>.</para>
  /// </summary>
  public sealed class YandexMoneyDonateFormWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexMoneyButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("description"));
      Assert.Null(widget.Field("sum"));
      Assert.True(widget.Field("cards").To<bool>());
      Assert.Equal((byte)YandexMoneyDonateFormText.Donate, widget.Field("text").To<byte>());
      Assert.Null(widget.Field("projectName"));
      Assert.Null(widget.Field("projectSite"));
      Assert.False(widget.Field("payerComment").To<bool>());
      Assert.Null(widget.Field("payerCommentHint"));
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.False(widget.Field("showDescription").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().Account(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Description_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().Description(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().Description(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("description"));
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Field("description").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("sum"));
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Field("sum").To<decimal>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Cards(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cards_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.True(widget.Field("cards").To<bool>());
      Assert.True(ReferenceEquals(widget.Cards(false), widget));
      Assert.False(widget.Field("cards").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.Equal((byte) YandexMoneyDonateFormText.Donate, widget.Field("text").To<byte>());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Field("text").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectName(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ProjectName_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().ProjectName(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().ProjectName(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("projectName"));
      Assert.True(ReferenceEquals(widget.ProjectName("projectName"), widget));
      Assert.Equal("projectName", widget.Field("projectName").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectSite(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ProjectSite_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().ProjectSite(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().ProjectSite(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("projectSite"));
      Assert.True(ReferenceEquals(widget.ProjectSite("projectSite"), widget));
      Assert.Equal("projectSite", widget.Field("projectSite").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.PayerComment(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerComment_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("payerComment").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerComment(), widget));
      Assert.True(widget.Field("payerComment").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.PayerCommentHint(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerCommentHint_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().PayerCommentHint(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().PayerCommentHint(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("payerCommentHint"));
      Assert.True(ReferenceEquals(widget.PayerCommentHint("payerCommentHint"), widget));
      Assert.Equal("payerCommentHint", widget.Field("payerCommentHint").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.PayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerFullName_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("payerFullName").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerFullName(), widget));
      Assert.True(widget.Field("payerFullName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.PayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerEmail_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("payerEmail").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerEmail(), widget));
      Assert.True(widget.Field("payerEmail").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.PayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void PayerPhone_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("payerPhone").To<bool>());
      Assert.True(ReferenceEquals(widget.PayerPhone(), widget));
      Assert.True(widget.Field("payerPhone").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ShowDescription(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowDescription_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("showDescription").To<bool>());
      Assert.True(ReferenceEquals(widget.ShowDescription(), widget));
      Assert.True(widget.Field("showDescription").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().ToString());
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().Description("description").ToString());
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().Account("account").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""133"" scrolling=""no"" src=""https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;payment-type-choice=on&amp;default-sum=&amp;targets=description&amp;project-name=&amp;project-site=&amp;button-text=01"" width=""523""></iframe>", new YandexMoneyDonateFormWidget().Account("account").Description("description").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""210"" scrolling=""no"" src=""https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=payerCommentHint&amp;fio=on&amp;mail=on&amp;phone=on"" width=""426""></iframe>", new YandexMoneyDonateFormWidget().Account("account").Description("description").ShowDescription().Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").PayerComment().PayerCommentHint("payerCommentHint").PayerFullName().PayerEmail().PayerPhone().ToString());
    }
  }
}