using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexWidgetsCreator"/>.</para>
/// </summary>
public sealed class YandexWidgetsCreatorTest : UnitTest
{
  private IYandexWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Yandex();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IYandexWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.Analytics()"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Widgets.Analytics().Should().BeOfType<YandexAnalyticsWidget>().And.NotBeSameAs(Widgets.Analytics());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Widgets.LikeButton().Should().BeOfType<YandexLikeButtonWidget>().And.NotBeSameAs(Widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Widgets.MoneyButton().Should().BeOfType<YandexMoneyButtonWidget>().And.NotBeSameAs(Widgets.MoneyButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyDonateForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Widgets.MoneyDonateForm().Should().BeOfType<YandexMoneyDonateFormWidget>().And.NotBeSameAs(Widgets.MoneyDonateForm());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyPaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Widgets.MoneyPaymentForm().Should().BeOfType<YandexMoneyPaymentFormWidget>().And.NotBeSameAs(Widgets.MoneyPaymentForm());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.SharePanel()"/> method.</para>
  /// </summary>
  [Fact]
  public void SharePanel_Method()
  {
    Widgets.SharePanel().Should().BeOfType<YandexSharePanelWidget>().And.NotBeSameAs(Widgets.SharePanel());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<YandexVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}