using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyPaymentFormWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyPaymentFormWidgetTest : Test
{
  private IYandexMoneyPaymentFormWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexMoneyPaymentFormWidgetTest() => Widget = Fixture.Create<IYandexMoneyPaymentFormWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyPaymentFormWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyPaymentFormWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyPaymentFormWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("DescriptionValue").Should().BeNull();
      widget.GetPropertyValue<decimal?>("SumValue").Should().BeNull();
      widget.GetPropertyValue<bool>("CardsValue").Should().BeTrue();
      widget.GetPropertyValue<byte>("TextValue").Should().Be((byte) YandexMoneyPaymentFormText.Pay);
      widget.GetPropertyValue<bool>("AskPayerPurposeValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerCommentValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerFullNameValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerEmailValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerPhoneValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerAddressValue").Should().BeFalse();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyPaymentFormWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new YandexMoneyPaymentFormWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IYandexMoneyPaymentFormWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyPaymentFormWidget().Description(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
      AssertionExtensions.Should(() => new YandexMoneyPaymentFormWidget().Description(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("description");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string description, IYandexMoneyPaymentFormWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionValue").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      new[] { decimal.MinValue, decimal.MaxValue}.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyPaymentFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal?>("SumValue").Should().Be(sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Cards(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cards_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.Cards(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("CardsValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte text, IYandexMoneyPaymentFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPurpose_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerPurpose(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPurposeValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerComment(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerComment_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerComment(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerCommentValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerFullName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerEmail(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerPhone(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerAddress_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget) => widget.AskPayerAddress(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerAddressValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMoneyPaymentFormWidget());
      Validate(Fixture.Create<IYandexMoneyPaymentFormWidget>());
    }

    return;

    static void Validate(IYandexMoneyPaymentFormWidget original)
    {
      var clone = original.Clone<IYandexMoneyPaymentFormWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("DescriptionValue").Should().Be(original.GetPropertyValue<string>("DescriptionValue"));
      clone.GetPropertyValue<decimal?>("SumValue").Should().Be(original.GetPropertyValue<decimal?>("SumValue"));
      clone.GetPropertyValue<bool>("CardsValue").Should().Be(original.GetPropertyValue<bool>("CardsValue"));
      clone.GetPropertyValue<byte>("TextValue").Should().Be(original.GetPropertyValue<byte>("TextValue"));
      clone.GetPropertyValue<bool>("AskPayerPurposeValue").Should().Be(original.GetPropertyValue<bool>("AskPayerPurposeValue"));
      clone.GetPropertyValue<bool>("AskPayerCommentValue").Should().Be(original.GetPropertyValue<bool>("AskPayerCommentValue"));
      clone.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(original.GetPropertyValue<bool>("AskPayerFullNameValue"));
      clone.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(original.GetPropertyValue<bool>("AskPayerEmailValue"));
      clone.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(original.GetPropertyValue<bool>("AskPayerPhoneValue"));
      clone.GetPropertyValue<bool>("AskPayerAddressValue").Should().Be(original.GetPropertyValue<bool>("AskPayerAddressValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMoneyPaymentFormWidget());
      Validate(new YandexMoneyPaymentFormWidget().Description("description"));
      Validate(new YandexMoneyPaymentFormWidget().Account("account"));
      Validate(new YandexMoneyPaymentFormWidget().Account("account").Description("description"), """<iframe allowtransparency="true" frameborder="0" height="200" scrolling="no" src="https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;payment-type-choice=on&amp;writer=seller&amp;targets=description&amp;default-sum=&amp;button-text=01" width="450"></iframe>""");
      Validate(new YandexMoneyPaymentFormWidget().Account("account").Description("description").Sum(1).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).AskPayerPurpose(true).AskPayerComment(true).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true), """<iframe allowtransparency="true" frameborder="0" height="255" scrolling="no" src="https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;writer=buyer&amp;targets-hint=description&amp;default-sum=1&amp;button-text=03&amp;comment=on&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on" width="450"></iframe>""");
      Validate(Fixture.Create<IYandexMoneyPaymentFormWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      if (html.IsUnset())
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