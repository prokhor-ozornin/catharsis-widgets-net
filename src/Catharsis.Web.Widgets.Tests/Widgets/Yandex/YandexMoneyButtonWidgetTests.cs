using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyButtonWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyButtonWidgetTests : ClassTest<YandexMoneyButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyButtonWidget>();

    var widget = new YandexMoneyButtonWidget();
    Assert.Null(widget.Account().Should().BeNull());
    widget.AskPayerFullName().Should().BeFalse();
    widget.AskPayerEmail().Should().BeFalse();
    widget.AskPayerPhone().Should().BeFalse();
    widget.AskPayerAddress().Should().BeFalse();
    widget.Color().Should().Be("orange");
    widget.Description().Should().BeNull();
    widget.Size().Should().Be("l");
    widget.Sum().Should().BeNull();
    widget.Text().Should().Be((byte) YandexMoneyButtonText.Pay);
    widget.Type().Should().Be("yamoney-payment-type");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IYandexMoneyButtonWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Color(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Color(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IYandexMoneyButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.Color().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Description(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Description(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IYandexMoneyButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.Color().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget)
    {
      widget.AskPayerFullName(enabled).Should().BeSameAs(widget);
      widget.AskPayerFullName().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] {false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget)
    {
      widget.AskPayerEmail(enabled).Should().BeSameAs(widget);
      widget.AskPayerEmail().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget)
    {
      widget.AskPayerPhone(enabled).Should().BeSameAs(widget);
      widget.AskPayerPhone().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerAddress(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerAddress_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget)
    {
      widget.AskPayerAddress(enabled).Should().BeSameAs(widget);
      widget.AskPayerAddress().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Size(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Size(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, IYandexMoneyButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { decimal.MinValue, decimal.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyButtonWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.Sum().Should().Be(sum);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte text, IYandexMoneyButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Type(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyButtonWidget().Type(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyButtonWidget().Type(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string type, IYandexMoneyButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.Type().Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new YandexMoneyButtonWidget().ToString());
    Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Description("description").Sum(1).ToString());
    Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Account("account").Sum(1).ToString());
    Assert.Equal(string.Empty, new YandexMoneyButtonWidget().Account("account").Description("description").ToString());
    Assert.Equal("""<iframe allowtransparency="true" frameborder="0" height="54" scrolling="no" src="https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;yamoney-payment-type=on&amp;button-text=01&amp;button-size=l&amp;button-color=orange&amp;targets=description&amp;default-sum=1" width="229"></iframe>""", new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).ToString());
    Assert.Equal("""<iframe allowtransparency="true" frameborder="0" height="54" scrolling="no" src="https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;any-card-payment-type=on&amp;button-text=03&amp;button-size=m&amp;button-color=white&amp;targets=description&amp;default-sum=1&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on" width="242"></iframe>""", new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Transfer).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true).ToString());
  }
}