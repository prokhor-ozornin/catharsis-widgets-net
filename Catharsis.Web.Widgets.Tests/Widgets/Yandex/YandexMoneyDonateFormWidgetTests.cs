using System;
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
      Assert.Null(widget.Account());
      Assert.Null(widget.DescriptionText());
      Assert.Null(widget.Sum());
      Assert.True(widget.Cards());
      Assert.Equal((byte)YandexMoneyDonateFormText.Donate, widget.Text());
      Assert.Null(widget.ProjectName());
      Assert.Null(widget.ProjectSite());
      Assert.False(widget.AskPayerComment());
      Assert.Null(widget.CommentHint());
      Assert.False(widget.AskPayerFullName());
      Assert.False(widget.AskPayerEmail());
      Assert.False(widget.AskPayerPhone());
      Assert.False(widget.Description());
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
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
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
      Assert.Null(widget.DescriptionText());
      Assert.True(ReferenceEquals(widget.DescriptionText("descriptionText"), widget));
      Assert.Equal("descriptionText", widget.DescriptionText());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Sum(decimal)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sum_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.Null(widget.Sum());
      Assert.True(ReferenceEquals(widget.Sum(1), widget));
      Assert.Equal(1, widget.Sum());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Cards(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Cards_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.True(widget.Cards());
      Assert.True(ReferenceEquals(widget.Cards(false), widget));
      Assert.False(widget.Cards());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Text(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.Equal((byte) YandexMoneyDonateFormText.Donate, widget.Text());
      Assert.True(ReferenceEquals(widget.Text(1), widget));
      Assert.Equal(1, widget.Text());
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
      Assert.Null(widget.ProjectName());
      Assert.True(ReferenceEquals(widget.ProjectName("projectName"), widget));
      Assert.Equal("projectName", widget.ProjectName());
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
      Assert.Null(widget.ProjectSite());
      Assert.True(ReferenceEquals(widget.ProjectSite("projectSite"), widget));
      Assert.Equal("projectSite", widget.ProjectSite());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerComment(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerComment_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.AskPayerComment());
      Assert.True(ReferenceEquals(widget.AskPayerComment(true), widget));
      Assert.True(widget.AskPayerComment());
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
      Assert.Null(widget.CommentHint());
      Assert.True(ReferenceEquals(widget.CommentHint("commentHint"), widget));
      Assert.Equal("commentHint", widget.CommentHint());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerFullName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerFullName_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.AskPayerFullName());
      Assert.True(ReferenceEquals(widget.AskPayerFullName(true), widget));
      Assert.True(widget.AskPayerFullName());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerEmail(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerEmail_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.AskPayerEmail());
      Assert.True(ReferenceEquals(widget.AskPayerEmail(true), widget));
      Assert.True(widget.AskPayerEmail());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerPhone(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AskPayerPhone_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.AskPayerPhone());
      Assert.True(ReferenceEquals(widget.AskPayerPhone(true), widget));
      Assert.True(widget.AskPayerPhone());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowDescription_Method()
    {
      var widget = new YandexMoneyDonateFormWidget();
      Assert.False(widget.Description());
      Assert.True(ReferenceEquals(widget.Description(true), widget));
      Assert.True(widget.Description());
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
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" height=""210"" scrolling=""no"" src=""https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=commentHint&amp;fio=on&amp;mail=on&amp;phone=on"" width=""426""></iframe>", new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").Description(true).Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").AskPayerComment(true).CommentHint("commentHint").AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).ToString());
    }
  }
}