using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
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

      Assert.Equal(new YandexHtmlHelper().Analytics().ToHtmlString(), new YandexHtmlHelper().Analytics(x => { }));
      Assert.Equal(new YandexHtmlHelper().Analytics().Account("account").ToHtmlString(), new YandexHtmlHelper().Analytics(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Like(IYandexHtmlHelper, Action{IYandexLikeButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Like(null));

      Assert.Equal(new YandexHtmlHelper().Like().ToHtmlString(), new YandexHtmlHelper().Like(x => { }));
      Assert.Equal(new YandexHtmlHelper().Like().Url("url").ToHtmlString(), new YandexHtmlHelper().Like(x => x.Url("url")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyButton(IYandexHtmlHelper, Action{IYandexMoneyButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyButton(null));

      Assert.Equal(new YandexHtmlHelper().MoneyButton().ToHtmlString(), new YandexHtmlHelper().MoneyButton(x => { }));
      Assert.Equal(new YandexHtmlHelper().MoneyButton().Account("account").Description("description").Sum(1).ToHtmlString(), new YandexHtmlHelper().MoneyButton(x => x.Account("account").Description("description").Sum(1)));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyDonateForm(IYandexHtmlHelper, Action{IYandexMoneyDonateFormWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyDonateForm_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyDonateForm(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyDonateForm(null));

      Assert.Equal(new YandexHtmlHelper().MoneyDonateForm().ToHtmlString(), new YandexHtmlHelper().MoneyDonateForm(x => { }));
      Assert.Equal(new YandexHtmlHelper().MoneyDonateForm().Account("account").Description("description").ToHtmlString(), new YandexHtmlHelper().MoneyDonateForm(x => x.Account("account").Description("description")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.MoneyPaymentForm(IYandexHtmlHelper, Action{IYandexMoneyPaymentFormWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void MoneyPaymentForm_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.MoneyPaymentForm(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().MoneyPaymentForm(null));

      Assert.Equal(new YandexHtmlHelper().MoneyPaymentForm().ToHtmlString(), new YandexHtmlHelper().MoneyPaymentForm(x => { }));
      Assert.Equal(new YandexHtmlHelper().MoneyPaymentForm().Account("account").ToHtmlString(), new YandexHtmlHelper().MoneyPaymentForm(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Share(IYandexHtmlHelper, Action{IYandexSharePanelWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Share_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Share(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Share(null));

      Assert.Equal(new YandexHtmlHelper().Share().ToHtmlString(), new YandexHtmlHelper().Share(x => { }));
      Assert.Equal(new YandexHtmlHelper().Share().Layout(YandexSharePanelLayout.Button).ToHtmlString(), new YandexHtmlHelper().Share(x => x.Layout(YandexSharePanelLayout.Button)));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexHtmlHelperExtensions.Video(IYandexHtmlHelper, Action{IYandexVideoWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexHtmlHelperExtensions.Video(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new YandexHtmlHelper().Video(null));

      Assert.Equal(new YandexHtmlHelper().Video().ToHtmlString(), new YandexHtmlHelper().Video(x => { }));
      Assert.Equal(new YandexHtmlHelper().Video().Id("id").Width("width").Height("height").User("user").ToHtmlString(), new YandexHtmlHelper().Video(x => x.Id("id").Width("width").Height("height").User("user")));
    }
  }
}