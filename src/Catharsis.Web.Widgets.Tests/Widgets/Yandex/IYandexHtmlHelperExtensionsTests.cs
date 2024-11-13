using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IYandexHtmlHelperExtensions"/>.</para>
/// </summary>
public sealed class IYandexHtmlHelperExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Analytics(IYandexWidgetCreator, Action{IYandexAnalyticsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Analytics(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().Analytics(null));

    Assert.Equal(new YandexWidgetCreator().Analytics().ToHtml(), new YandexWidgetCreator().Analytics(x => { }));
    Assert.Equal(new YandexWidgetCreator().Analytics().Account("account").ToHtml(), new YandexWidgetCreator().Analytics(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.LikeButton(IYandexWidgetCreator, Action{IYandexLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.LikeButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().LikeButton(null));

    Assert.Equal(new YandexWidgetCreator().LikeButton().ToHtml(), new YandexWidgetCreator().LikeButton(x => { }));
    Assert.Equal(new YandexWidgetCreator().LikeButton().Url("url").ToHtml(), new YandexWidgetCreator().LikeButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyButton(IYandexWidgetCreator, Action{IYandexMoneyButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().MoneyButton(null));

    Assert.Equal(new YandexWidgetCreator().MoneyButton().ToHtml(), new YandexWidgetCreator().MoneyButton(x => { }));
    Assert.Equal(new YandexWidgetCreator().MoneyButton().Account("account").Description("description").Sum(1).ToHtml(), new YandexWidgetCreator().MoneyButton(x => x.Account("account").Description("description").Sum(1)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyDonateForm(IYandexWidgetCreator, Action{IYandexMoneyDonateFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyDonateForm(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().MoneyDonateForm(null));

    Assert.Equal(new YandexWidgetCreator().MoneyDonateForm().ToHtml(), new YandexWidgetCreator().MoneyDonateForm(x => { }));
    Assert.Equal(new YandexWidgetCreator().MoneyDonateForm().Account("account").DescriptionText("description").ToHtml(), new YandexWidgetCreator().MoneyDonateForm(x => x.Account("account").DescriptionText("description")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyPaymentForm(IYandexWidgetCreator, Action{IYandexMoneyPaymentFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyPaymentForm(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().MoneyPaymentForm(null));

    Assert.Equal(new YandexWidgetCreator().MoneyPaymentForm().ToHtml(), new YandexWidgetCreator().MoneyPaymentForm(x => { }));
    Assert.Equal(new YandexWidgetCreator().MoneyPaymentForm().Account("account").ToHtml(), new YandexWidgetCreator().MoneyPaymentForm(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.SharePanel(IYandexWidgetCreator, Action{IYandexSharePanelWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void SharePanel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.SharePanel(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().SharePanel(null));

    Assert.Equal(new YandexWidgetCreator().SharePanel().ToHtml(), new YandexWidgetCreator().SharePanel(x => { }));
    Assert.Equal(new YandexWidgetCreator().SharePanel().Layout(YandexSharePanelLayout.Button).ToHtml(), new YandexWidgetCreator().SharePanel(x => x.Layout(YandexSharePanelLayout.Button)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Video(IYandexWidgetCreator, Action{IYandexVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Video(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetCreator().Video(null));

    Assert.Equal(new YandexWidgetCreator().Video().ToHtml(), new YandexWidgetCreator().Video(x => { }));
    Assert.Equal(new YandexWidgetCreator().Video().Id("id").Width("width").Height("height").User("user").ToHtml(), new YandexWidgetCreator().Video(x => x.Id("id").Width("width").Height("height").User("user")));
  }
}