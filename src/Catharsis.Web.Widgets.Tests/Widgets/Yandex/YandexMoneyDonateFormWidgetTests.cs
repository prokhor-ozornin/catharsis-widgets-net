using System.Text;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyDonateFormWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyDonateFormWidgetTests : ClassTest<YandexMoneyDonateFormWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMoneyButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMoneyDonateFormWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMoneyDonateFormWidget>();

    var widget = new YandexMoneyDonateFormWidget();
    widget.Account().Should().BeNull();
    widget.DescriptionText().Should().BeNull();
    widget.Sum().Should().BeNull();
    widget.Cards().Should().BeTrue();
    widget.Text().Should().Be((byte) YandexMoneyDonateFormText.Donate);
    widget.ProjectName().Should().BeNull();
    widget.ProjectSite().Should().BeNull();
    widget.AskPayerComment().Should().BeFalse();
    widget.CommentHint().Should().BeNull();
    widget.AskPayerFullName().Should().BeFalse();
    widget.AskPayerEmail().Should().BeFalse();
    widget.AskPayerPhone().Should().BeFalse();
    widget.Description().Should().BeFalse();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IYandexMoneyDonateFormWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.DescriptionText(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DescriptionText_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().DescriptionText(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().DescriptionText(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string description, IYandexMoneyDonateFormWidget widget)
    {
      widget.DescriptionText(description).Should().BeSameAs(widget);
      widget.DescriptionText().Should().Be(description);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { decimal.MinValue, decimal.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(decimal sum, IYandexMoneyDonateFormWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.Sum().Should().Be(sum);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Cards(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cards_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.Cards(enabled).Should().BeSameAs(widget);
      widget.Cards().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte text, IYandexMoneyDonateFormWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectName(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectName_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().ProjectName(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().ProjectName(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string name, IYandexMoneyDonateFormWidget widget)
    {
      widget.ProjectName(name).Should().BeSameAs(widget);
      widget.ProjectName().Should().Be(name);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectSite(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectSite_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().ProjectSite(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().ProjectSite(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string name, IYandexMoneyDonateFormWidget widget)
    {
      widget.ProjectSite(name).Should().BeSameAs(widget);
      widget.ProjectSite().Should().Be(name);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerComment(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerComment_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.AskPayerComment(enabled).Should().BeSameAs(widget);
      widget.AskPayerComment().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.CommentHint(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentHint_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YandexMoneyDonateFormWidget().CommentHint(null));
    Assert.Throws<ArgumentException>(() => new YandexMoneyDonateFormWidget().CommentHint(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hint, IYandexMoneyDonateFormWidget widget)
    {
      widget.CommentHint(hint).Should().BeSameAs(widget);
      widget.CommentHint().Should().Be(hint);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.AskPayerFullName(enabled).Should().BeSameAs(widget);
      widget.AskPayerFullName().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.AskPayerEmail(enabled).Should().BeSameAs(widget);
      widget.AskPayerEmail().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.AskPayerPhone(enabled).Should().BeSameAs(widget);
      widget.AskPayerPhone().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ShowDescription_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YandexMoneyDonateFormWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYandexMoneyDonateFormWidget widget)
    {
      widget.Description(enabled).Should().BeSameAs(widget);
      widget.Description().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().ToString());
    Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().DescriptionText("description").ToString());
    Assert.Equal(string.Empty, new YandexMoneyDonateFormWidget().Account("account").ToString());
    Assert.Equal("""<iframe allowtransparency="true" frameborder="0" height="133" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;payment-type-choice=on&amp;default-sum=&amp;targets=description&amp;project-name=&amp;project-site=&amp;button-text=01" width="523"></iframe>""", new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").ToString());
    Assert.Equal(new StringBuilder().Append("""<iframe allowtransparency="true" frameborder="0" height="210" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=commentHint&amp;fio=on&amp;mail=on&amp;phone=on" width="426"></iframe>""").ToString(), new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").Description(true).Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").AskPayerComment(true).CommentHint("commentHint").AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true).ToString());
  }
}