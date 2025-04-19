using System.Text;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyDonateFormWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyDonateFormWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyDonateFormWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyDonateFormWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("DescriptionTextProperty").Should().BeNull();
      widget.GetPropertyValue<decimal?>("SumProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("CardsProperty").Should().BeTrue();
      widget.GetPropertyValue<byte>("TextProperty").Should().Be((byte) YandexMoneyDonateFormText.Donate);
      widget.GetPropertyValue<string>("ProjectNameProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ProjectSiteProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerCommentProperty").Should().BeFalse();
      widget.GetPropertyValue<string>("CommentHintProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerFullNameProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerEmailProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerPhoneProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("DescriptionProperty").Should().BeFalse();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new YandexMoneyDonateFormWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IYandexMoneyDonateFormWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.DescriptionText(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DescriptionText_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().DescriptionText(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().DescriptionText(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("description");

      new YandexMoneyDonateFormWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string description, IYandexMoneyDonateFormWidget widget) => widget.DescriptionText(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionTextProperty").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { decimal.MinValue, decimal.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyDonateFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal?>("SumProperty").Should().Be(sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Cards(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cards_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.Cards(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("CardsProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte text, IYandexMoneyDonateFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectName(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectName_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectName(null)).ThrowExactly<ArgumentNullException>().WithParameterName("name");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectName(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("name");

      new YandexMoneyDonateFormWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string name, IYandexMoneyDonateFormWidget widget) => widget.ProjectName(name).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ProjectNameProperty").Should().Be(name);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectSite(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectSite_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectSite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("site");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectSite(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("site");

      new YandexMoneyDonateFormWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string name, IYandexMoneyDonateFormWidget widget) => widget.ProjectSite(name).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ProjectSiteProperty").Should().Be(name);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerComment(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerComment_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerComment(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerCommentProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.CommentHint(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentHint_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().CommentHint(null)).ThrowExactly<ArgumentNullException>().WithParameterName("hint");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().CommentHint(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("hint");

      new YandexMoneyDonateFormWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string hint, IYandexMoneyDonateFormWidget widget) => widget.CommentHint(hint).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CommentHintProperty").Should().Be(hint);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerFullName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerFullNameProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerEmail(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerEmailProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerPhone(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPhoneProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ShowDescription_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyDonateFormWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.Description(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("DescriptionProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMoneyDonateFormWidget());
      Validate(new YandexMoneyDonateFormWidget().DescriptionText("description"));
      Validate(new YandexMoneyDonateFormWidget().Account("account"));
      Validate(new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description"), """<iframe allowtransparency="true" frameborder="0" height="133" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;payment-type-choice=on&amp;default-sum=&amp;targets=description&amp;project-name=&amp;project-site=&amp;button-text=01" width="523"></iframe>""");
      Validate(new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").Description(true).Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").AskPayerComment(true).CommentHint("commentHint").AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true), new StringBuilder().Append("""<iframe allowtransparency="true" frameborder="0" height="210" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=commentHint&amp;fio=on&amp;mail=on&amp;phone=on" width="426"></iframe>""").ToString());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}