using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyButtonWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyButtonWidgetTest : Test
{
  private IYandexMoneyButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexMoneyButtonWidgetTest() => Widget = Fixture.Create<IYandexMoneyButtonWidget>();

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
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerFullNameValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerEmailValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerPhoneValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerAddressValue").Should().BeFalse();
      widget.GetPropertyValue<string>("ColorValue").Should().Be("orange");
      widget.GetPropertyValue<string>("DescriptionValue").Should().BeNull();
      widget.GetPropertyValue<string>("SizeValue").Should().Be("l");
      widget.GetPropertyValue<decimal?>("SumValue").Should().BeNull();
      widget.GetPropertyValue<byte>("TextValue").Should().Be((byte) YandexMoneyButtonText.Pay);
      widget.GetPropertyValue<string>("TypeValue").Should().Be("yamoney-payment-type");
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IYandexMoneyButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string color, IYandexMoneyButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string description, IYandexMoneyButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionValue").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerFullName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      new[] {false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerEmail(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerPhone(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.AskPayerAddress(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerAddress_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyButtonWidget widget) => widget.AskPayerAddress(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerAddressValue").Should().Be(enabled);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string size, IYandexMoneyButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      new[] { decimal.MinValue, decimal.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyButtonWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal?>("SumValue").Should().Be(sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte text, IYandexMoneyButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be(text);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string type, IYandexMoneyButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeValue").Should().Be(type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMoneyButtonWidget());
      Validate(Fixture.Create<IYandexMoneyButtonWidget>());
    }

    return;

    static void Validate(IYandexMoneyButtonWidget original)
    {
      var clone = original.Clone<IYandexMoneyButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("ColorValue").Should().Be(original.GetPropertyValue<string>("ColorValue"));
      clone.GetPropertyValue<string>("DescriptionValue").Should().Be(original.GetPropertyValue<string>("DescriptionValue"));
      clone.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(original.GetPropertyValue<bool>("AskPayerFullNameValue"));
      clone.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(original.GetPropertyValue<bool>("AskPayerEmailValue"));
      clone.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(original.GetPropertyValue<bool>("AskPayerPhoneValue"));
      clone.GetPropertyValue<bool>("AskPayerAddressValue").Should().Be(original.GetPropertyValue<bool>("AskPayerAddressValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<decimal?>("SumValue").Should().Be(original.GetPropertyValue<decimal?>("SumValue"));
      clone.GetPropertyValue<byte>("TextValue").Should().Be(original.GetPropertyValue<byte>("TextValue"));
      clone.GetPropertyValue<string>("TypeValue").Should().Be(original.GetPropertyValue<string>("TypeValue"));
    }
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
      Validate(Fixture.Create<IYandexMoneyButtonWidget>());
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