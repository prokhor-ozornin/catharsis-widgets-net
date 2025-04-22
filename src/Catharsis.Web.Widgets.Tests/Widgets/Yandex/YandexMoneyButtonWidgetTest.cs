using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyButtonWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexMoneyButtonWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerFullNameProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerEmailProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerPhoneProperty").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerAddressProperty").Should().BeFalse();
      widget.GetPropertyValue<string>("ColorProperty").Should().Be("orange");
      widget.GetPropertyValue<string>("DescriptionProperty").Should().BeNull();
      widget.GetPropertyValue<string>("SizeProperty").Should().Be("l");
      widget.GetPropertyValue<decimal?>("SumProperty").Should().BeNull();
      widget.GetPropertyValue<byte>("TextProperty").Should().Be((byte) YandexMoneyButtonText.Pay);
      widget.GetPropertyValue<string>("TypeProperty").Should().Be("yamoney-payment-type");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new YandexMoneyButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IYandexMoneyButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Color(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Color(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new YandexMoneyButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IYandexMoneyButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Description(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Description(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("description");

      new YandexMoneyButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string description, IYandexMoneyButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionProperty").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerFullName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerFullNameProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] {false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerEmail(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerEmailProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerPhone(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPhoneProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerAddress(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerAddress_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerAddress(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerAddressProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new YandexMoneyButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string size, IYandexMoneyButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] { decimal.MinValue, decimal.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyButtonWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal?>("SumProperty").Should().Be(sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new YandexMoneyButtonWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte text, IYandexMoneyButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Type(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Type(null)).ThrowExactly<ArgumentNullException>().WithParameterName("type");
      AssertionExtensions.Should(() => new YandexMoneyButtonWidget().Type(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("type");

      new YandexMoneyButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string type, IYandexMoneyButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeProperty").Should().Be(type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMoneyButtonWidget());
      Validate(new YandexMoneyButtonWidget().Description("description").Sum(1));
      Validate(new YandexMoneyButtonWidget().Account("account").Sum(1));
      Validate(new YandexMoneyButtonWidget().Account("account").Description("description"));
      Validate(new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1), """<iframe allowtransparency="true" frameborder="0" height="54" scrolling="no" src="https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;yamoney-payment-type=on&amp;button-text=01&amp;button-size=l&amp;button-color=orange&amp;targets=description&amp;default-sum=1" width="229"></iframe>""");
      Validate(new YandexMoneyButtonWidget().Account("account").Description("description").Sum(1).Type(YandexMoneyButtonType.Card).Text(YandexMoneyButtonText.Transfer).Size(YandexMoneyButtonSize.Medium).Color(YandexMoneyButtonColor.White).AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).AskPayerAddress(true), """<iframe allowtransparency="true" frameborder="0" height="54" scrolling="no" src="https://money.yandex.ru/embed/small.xml?account=account&amp;quickpay=small&amp;any-card-payment-type=on&amp;button-text=03&amp;button-size=m&amp;button-color=white&amp;targets=description&amp;default-sum=1&amp;fio=on&amp;mail=on&amp;phone=on&amp;address=on" width="242"></iframe>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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