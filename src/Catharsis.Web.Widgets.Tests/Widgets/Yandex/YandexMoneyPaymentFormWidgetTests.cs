using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyPaymentFormWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyPaymentFormWidgetTests : ClassTest<YandexMoneyPaymentFormWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyPaymentFormWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyPaymentFormWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyPaymentFormWidget>();

    var widget = new YandexMoneyPaymentFormWidget();
    widget.Account().Should().BeNull();
    widget.Description().Should().BeNull();
    widget.Sum().Should().BeNull();
    widget.Cards().Should().BeTrue();
    widget.Text().Should().Be((byte) YandexMoneyPaymentFormText.Pay);
    widget.AskPayerPurpose().Should().BeFalse();
    widget.AskPayerComment().Should().BeFalse();
    widget.AskPayerFullName().Should().BeFalse();
    widget.AskPayerEmail().Should().BeFalse();
    widget.AskPayerPhone().Should().BeFalse();
    widget.AskPayerAddress().Should().BeFalse();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyPaymentFormWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyPaymentFormWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyPaymentFormWidget().Description(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyPaymentFormWidget().Description(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string description, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Description(description).Should().BeSameAs(widget);
      widget.Description().Should().Be(description);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { decimal.MinValue, decimal.MaxValue}.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.Sum().Should().Be(sum);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Cards(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cards_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Cards(enabled).Should().BeSameAs(widget);
      widget.Cards().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte text, IYandexMoneyPaymentFormWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPurpose_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerPurpose(enabled).Should().BeSameAs(widget);
      widget.AskPayerPurpose().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerComment(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerComment_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerComment(enabled).Should().BeSameAs(widget);
      widget.AskPayerComment().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerFullName(enabled).Should().BeSameAs(widget);
      widget.AskPayerFullName().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerEmail(enabled).Should().BeSameAs(widget);
      widget.AskPayerEmail().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerPhone(enabled).Should().BeSameAs(widget);
      widget.AskPayerPhone().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerAddress_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyPaymentFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyPaymentFormWidget widget)
    {
      widget.AskPayerAddress(enabled).Should().BeSameAs(widget);
      widget.AskPayerAddress().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyPaymentFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().ToString());
    Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().Description("description").ToString());
    Assert.Equal(string.Empty, new YandexMoneyPaymentFormWidget().Account("account").ToString());
    Assert.Equal("""<iframe allowtransparency="true" frameborder="0" height="200" scrolling="no" src="https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;payment-type-choice=on&amp;writer=seller&amp;targets=description&amp;default-sum=&amp;button-text=01" width="450"></iframe>""", new YandexMoneyPaymentFormWidget().Account("account").Description("description").ToString());
    Assert.Equal("""<iframe allowtransparency="true" frameborder="0" height="255" scrolling="no" src="https://money.yandex.ru/embed/shop.xml?account=account&amp;quickpay=shop&amp;writer=buyer&amp;targets-hint=description&amp;default-sum=1&amp;button-text=03&amp;comment=on&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on" width="450"></iframe>""", new YandexMoneyPaymentFormWidget().Account("account").Description("description").Sum(1).Cards(false).Text(YandexMoneyPaymentFormText.Transfer).AskPayerPurpose(true).AskPayerComment(true).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true).ToString());
  }
}