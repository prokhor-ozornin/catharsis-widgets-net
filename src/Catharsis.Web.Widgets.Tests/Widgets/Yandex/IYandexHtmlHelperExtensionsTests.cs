using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IYandexHtmlHelperExtensions"/>.</para>
/// </summary>
public sealed class IYandexHtmlHelperExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Analytics(IYandexHtmlHelper, Action{IYandexAnalyticsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Analytics(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Analytics(null));

    Assert.Equal(new YandexHtmlHelper().Analytics().ToHtml(), new YandexHtmlHelper().Analytics(x => { }));
    Assert.Equal(new YandexHtmlHelper().Analytics().Account("account").ToHtml(), new YandexHtmlHelper().Analytics(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.LikeButton(IYandexHtmlHelper, Action{IYandexLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.LikeButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().LikeButton(null));

    Assert.Equal(new YandexHtmlHelper().LikeButton().ToHtml(), new YandexHtmlHelper().LikeButton(x => { }));
    Assert.Equal(new YandexHtmlHelper().LikeButton().Url("url").ToHtml(), new YandexHtmlHelper().LikeButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyButton(IYandexHtmlHelper, Action{IYandexMoneyButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyButton(null));

    Assert.Equal(new YandexHtmlHelper().MoneyButton().ToHtml(), new YandexHtmlHelper().MoneyButton(x => { }));
    Assert.Equal(new YandexHtmlHelper().MoneyButton().Account("account").Description("description").Sum(1).ToHtml(), new YandexHtmlHelper().MoneyButton(x => x.Account("account").Description("description").Sum(1)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyDonateForm(IYandexHtmlHelper, Action{IYandexMoneyDonateFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyDonateForm(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyDonateForm(null));

    Assert.Equal(new YandexHtmlHelper().MoneyDonateForm().ToHtml(), new YandexHtmlHelper().MoneyDonateForm(x => { }));
    Assert.Equal(new YandexHtmlHelper().MoneyDonateForm().Account("account").DescriptionText("description").ToHtml(), new YandexHtmlHelper().MoneyDonateForm(x => x.Account("account").DescriptionText("description")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyPaymentForm(IYandexHtmlHelper, Action{IYandexMoneyPaymentFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyPaymentForm(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyPaymentForm(null));

    Assert.Equal(new YandexHtmlHelper().MoneyPaymentForm().ToHtml(), new YandexHtmlHelper().MoneyPaymentForm(x => { }));
    Assert.Equal(new YandexHtmlHelper().MoneyPaymentForm().Account("account").ToHtml(), new YandexHtmlHelper().MoneyPaymentForm(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.SharePanel(IYandexHtmlHelper, Action{IYandexSharePanelWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void SharePanel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.SharePanel(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().SharePanel(null));

    Assert.Equal(new YandexHtmlHelper().SharePanel().ToHtml(), new YandexHtmlHelper().SharePanel(x => { }));
    Assert.Equal(new YandexHtmlHelper().SharePanel().Layout(YandexSharePanelLayout.Button).ToHtml(), new YandexHtmlHelper().SharePanel(x => x.Layout(YandexSharePanelLayout.Button)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Video(IYandexHtmlHelper, Action{IYandexVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Video(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Video(null));

    Assert.Equal(new YandexHtmlHelper().Video().ToHtml(), new YandexHtmlHelper().Video(x => { }));
    Assert.Equal(new YandexHtmlHelper().Video().Id("id").Width("width").Height("height").User("user").ToHtml(), new YandexHtmlHelper().Video(x => x.Id("id").Width("width").Height("height").User("user")));
  }
}