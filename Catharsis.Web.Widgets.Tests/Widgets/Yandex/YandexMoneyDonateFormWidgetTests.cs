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
      Assert.Null(widget.Field("descriptionText"));
      Assert.Null(widget.Field("sum"));
      Assert.True(widget.Field("cards").To<bool>());
      Assert.Equal((byte)YandexMoneyDonateFormText.Donate, widget.Field("text").To<byte>());
      Assert.Null(widget.Field("projectName"));
      Assert.Null(widget.Field("projectSite"));
      Assert.False(widget.Field("askPayerComment").To<bool>());
      Assert.Null(widget.Field("commentHint"));
      Assert.False(widget.Field("askPayerFullName").To<bool>());
      Assert.False(widget.Field("askPayerEmail").To<bool>());
      Assert.False(widget.Field("askPayerPhone").To<bool>());
      Assert.False(widget.Field("description").To<bool>());
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
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.DescriptionText(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void DescriptionText_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().DescriptionText(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().DescriptionText(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("descriptionText"));
      Assert.True(ReferenceEquals(widget.DescriptionText("descriptionText"), widget));
      Assert.Equal("descriptionText", widget.Field("descriptionText").To<string>());
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
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerComment(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerComment_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("askPayerComment").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerComment(), widget));
      Assert.True(widget.Field("askPayerComment").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.CommentHint(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void CommentHint_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().CommentHint(null));
      Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().CommentHint(string.Empty));

      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Field("commentHint"));
      Assert.True(ReferenceEquals(widget.CommentHint("commentHint"), widget));
      Assert.Equal("commentHint", widget.Field("commentHint").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerFullName_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("askPayerFullName").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerFullName(), widget));
      Assert.True(widget.Field("askPayerFullName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerEmail_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("askPayerEmail").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerEmail(), widget));
      Assert.True(widget.Field("askPayerEmail").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerPhone_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("askPayerPhone").To<bool>());
      Assert.True(ReferenceEquals(widget.AskPayerPhone(), widget));
      Assert.True(widget.Field("askPayerPhone").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowDescription_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Field("description").To<bool>());
      Assert.True(ReferenceEquals(widget.Description(), widget));
      Assert.True(widget.Field("description").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().ToString());
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().DescriptionText("description").ToString());
      Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().Account("account").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""133"" scrolling=""no"" src=""https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;payment-type-choice=on&amp;default-sum=&amp;targets=description&amp;project-name=&amp;project-site=&amp;button-text=01"" width=""523""></iframe>", new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""210"" scrolling=""no"" src=""https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=commentHint&amp;fio=on&amp;mail=on&amp;phone=on"" width=""426""></iframe>", new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").Description().Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").AskPayerComment().CommentHint("commentHint").AskPayerFullName().AskPayerEmail().AskPayerPhone().ToString());
    }
  }
}