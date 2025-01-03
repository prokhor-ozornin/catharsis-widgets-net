using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexWidgetsCreator"/>.</para>
/// </summary>
public sealed class YandexWidgetsCreatorTests : ClassTest<YandexWidgetsCreator>
{
  private readonly IYandexWidgetsCreator widgets = Widgets.Create.Yandex();

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
    widgets.Analytics().Should().BeOfType<YandexAnalyticsWidget>().And.NotBeSameAs(widgets.Analytics());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    widgets.LikeButton().Should().BeOfType<YandexLikeButtonWidget>().And.NotBeSameAs(widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    widgets.MoneyButton().Should().BeOfType<YandexMoneyButtonWidget>().And.NotBeSameAs(widgets.MoneyButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyDonateForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    widgets.MoneyDonateForm().Should().BeOfType<YandexMoneyDonateFormWidget>().And.NotBeSameAs(widgets.MoneyDonateForm());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.MoneyPaymentForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    widgets.MoneyPaymentForm().Should().BeOfType<YandexMoneyPaymentFormWidget>().And.NotBeSameAs(widgets.MoneyPaymentForm());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.SharePanel()"/> method.</para>
  /// </summary>
  [Fact]
  public void SharePanel_Method()
  {
    widgets.SharePanel().Should().BeOfType<YandexSharePanelWidget>().And.NotBeSameAs(widgets.SharePanel());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<YandexVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}