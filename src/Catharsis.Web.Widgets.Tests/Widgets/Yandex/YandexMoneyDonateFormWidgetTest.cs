using System.Text;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMoneyDonateFormWidget"/>.</para>
/// </summary>
public sealed class YandexMoneyDonateFormWidgetTest : Test
{
  private IYandexMoneyDonateFormWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexMoneyDonateFormWidgetTest() => Widget = Fixture<IYandexMoneyDonateFormWidget>.Create();

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
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("DescriptionTextValue").Should().BeNull();
      widget.GetPropertyValue<decimal?>("SumValue").Should().BeNull();
      widget.GetPropertyValue<bool>("CardsValue").Should().BeTrue();
      widget.GetPropertyValue<byte>("TextValue").Should().Be((byte) YandexMoneyDonateFormText.Donate);
      widget.GetPropertyValue<string>("ProjectNameValue").Should().BeNull();
      widget.GetPropertyValue<string>("ProjectSiteValue").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerCommentValue").Should().BeFalse();
      widget.GetPropertyValue<string>("CommentHintValue").Should().BeNull();
      widget.GetPropertyValue<bool>("AskPayerFullNameValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerEmailValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("AskPayerPhoneValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("DescriptionValue").Should().BeFalse();
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IYandexMoneyDonateFormWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string description, IYandexMoneyDonateFormWidget widget) => widget.DescriptionText(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionTextValue").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Sum(decimal)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      new[] { decimal.MinValue, decimal.MaxValue, Fixture<decimal>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(decimal sum, IYandexMoneyDonateFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal?>("SumValue").Should().Be(sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Cards(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cards_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.Cards(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("CardsValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Text(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte text, IYandexMoneyDonateFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be(text);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string name, IYandexMoneyDonateFormWidget widget) => widget.ProjectName(name).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ProjectNameValue").Should().Be(name);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ProjectSite(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectSite_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectSite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new YandexMoneyDonateFormWidget().ProjectSite(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string name, IYandexMoneyDonateFormWidget widget) => widget.ProjectSite(name).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ProjectSiteValue").Should().Be(name);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerComment(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerComment_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerComment(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerCommentValue").Should().Be(enabled);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string hint, IYandexMoneyDonateFormWidget widget) => widget.CommentHint(hint).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CommentHintValue").Should().Be(hint);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerFullName(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerFullName_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerFullName(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerEmail(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerEmail_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerEmail(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.AskPayerPhone(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AskPayerPhone_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.AskPayerPhone(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Description(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void ShowDescription_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IYandexMoneyDonateFormWidget widget) => widget.Description(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("DescriptionValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexMoneyDonateFormWidget());
      Test(Fixture<YandexMoneyDonateFormWidget>.Create());
    }

    return;

    static void Test(IYandexMoneyDonateFormWidget original)
    {
      var clone = original.Clone<IYandexMoneyDonateFormWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<bool>("DescriptionValue").Should().Be(original.GetPropertyValue<bool>("DescriptionValue"));
      clone.GetPropertyValue<decimal?>("SumValue").Should().Be(original.GetPropertyValue<decimal?>("SumValue"));
      clone.GetPropertyValue<bool>("CardsValue").Should().Be(original.GetPropertyValue<bool>("CardsValue"));
      clone.GetPropertyValue<byte>("TextValue").Should().Be(original.GetPropertyValue<byte>("TextValue"));
      clone.GetPropertyValue<string>("ProjectNameValue").Should().Be(original.GetPropertyValue<string>("ProjectNameValue"));
      clone.GetPropertyValue<string>("ProjectSiteValue").Should().Be(original.GetPropertyValue<string>("ProjectSiteValue"));
      clone.GetPropertyValue<bool>("AskPayerCommentValue").Should().Be(original.GetPropertyValue<bool>("AskPayerCommentValue"));
      clone.GetPropertyValue<string>("CommentHintValue").Should().Be(original.GetPropertyValue<string>("CommentHintValue"));
      clone.GetPropertyValue<bool>("AskPayerFullNameValue").Should().Be(original.GetPropertyValue<bool>("AskPayerFullNameValue"));
      clone.GetPropertyValue<bool>("AskPayerEmailValue").Should().Be(original.GetPropertyValue<bool>("AskPayerEmailValue"));
      clone.GetPropertyValue<bool>("AskPayerPhoneValue").Should().Be(original.GetPropertyValue<bool>("AskPayerPhoneValue"));
      clone.GetPropertyValue<string>("DescriptionTextValue").Should().Be(original.GetPropertyValue<string>("DescriptionTextValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMoneyDonateFormWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexMoneyDonateFormWidget());
      Test(new YandexMoneyDonateFormWidget().DescriptionText("description"));
      Test(new YandexMoneyDonateFormWidget().Account("account"));
      Test(new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description"), """<iframe allowtransparency="true" frameborder="0" height="133" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;payment-type-choice=on&amp;default-sum=&amp;targets=description&amp;project-name=&amp;project-site=&amp;button-text=01" width="523"></iframe>""");
      Test(new YandexMoneyDonateFormWidget().Account("account").DescriptionText("description").Description(true).Sum(1).Cards(false).Text(YandexMoneyDonateFormText.Transfer).ProjectName("projectName").ProjectSite("projectSite").AskPayerComment(true).CommentHint("commentHint").AskPayerFullName(true).AskPayerEmail(true).AskPayerPhone(true), new StringBuilder().Append("""<iframe allowtransparency="true" frameborder="0" height="210" scrolling="no" src="https://money.yandex.ru/embed/donate.xml?account=account&amp;quickpay=donate&amp;default-sum=1&amp;targets=description&amp;target-visibility=on&amp;project-name=projectName&amp;project-site=projectSite&amp;button-text=03&amp;comment=on&amp;hint=commentHint&amp;fio=on&amp;mail=on&amp;phone=on" width="426"></iframe>""").ToString());
      Test(Fixture<YandexMoneyDonateFormWidget>.Create());
    }

    return;

    static void Test(IYandexMoneyDonateFormWidget widget, params string[] html)
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