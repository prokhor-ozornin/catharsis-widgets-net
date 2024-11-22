using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IYandexWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.Analytics(IYandexWidgetsCreator, Action{IYandexAnalyticsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.Analytics(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().Analytics(null));

    Assert.Equal(new YandexWidgetsCreator().Analytics().ToHtml(), new YandexWidgetsCreator().Analytics(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().Analytics().Account("account").ToHtml(), new YandexWidgetsCreator().Analytics(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.LikeButton(IYandexWidgetsCreator, Action{IYandexLikeButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.LikeButton(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().LikeButton(null));

    Assert.Equal(new YandexWidgetsCreator().LikeButton().ToHtml(), new YandexWidgetsCreator().LikeButton(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().LikeButton().Url("url").ToHtml(), new YandexWidgetsCreator().LikeButton(x => x.Url("url")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.MoneyButton(IYandexWidgetsCreator, Action{IYandexMoneyButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.MoneyButton(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().MoneyButton(null));

    Assert.Equal(new YandexWidgetsCreator().MoneyButton().ToHtml(), new YandexWidgetsCreator().MoneyButton(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().MoneyButton().Account("account").Description("description").Sum(1).ToHtml(), new YandexWidgetsCreator().MoneyButton(x => x.Account("account").Description("description").Sum(1)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.MoneyDonateForm(IYandexWidgetsCreator, Action{IYandexMoneyDonateFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyDonateForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.MoneyDonateForm(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().MoneyDonateForm(null));

    Assert.Equal(new YandexWidgetsCreator().MoneyDonateForm().ToHtml(), new YandexWidgetsCreator().MoneyDonateForm(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().MoneyDonateForm().Account("account").DescriptionText("description").ToHtml(), new YandexWidgetsCreator().MoneyDonateForm(x => x.Account("account").DescriptionText("description")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.MoneyPaymentForm(IYandexWidgetsCreator, Action{IYandexMoneyPaymentFormWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void MoneyPaymentForm_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.MoneyPaymentForm(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().MoneyPaymentForm(null));

    Assert.Equal(new YandexWidgetsCreator().MoneyPaymentForm().ToHtml(), new YandexWidgetsCreator().MoneyPaymentForm(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().MoneyPaymentForm().Account("account").ToHtml(), new YandexWidgetsCreator().MoneyPaymentForm(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.SharePanel(IYandexWidgetsCreator, Action{IYandexSharePanelWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void SharePanel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.SharePanel(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().SharePanel(null));

    Assert.Equal(new YandexWidgetsCreator().SharePanel().ToHtml(), new YandexWidgetsCreator().SharePanel(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().SharePanel().Layout(YandexSharePanelLayout.Button).ToHtml(), new YandexWidgetsCreator().SharePanel(x => x.Layout(YandexSharePanelLayout.Button)));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexWidgetsCreatorExtensions.Video(IYandexWidgetsCreator, Action{IYandexVideoWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexWidgetsCreatorExtensions.Video(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new YandexWidgetsCreator().Video(null));

    Assert.Equal(new YandexWidgetsCreator().Video().ToHtml(), new YandexWidgetsCreator().Video(_ => { }));
    Assert.Equal(new YandexWidgetsCreator().Video().Id("id").Width("width").Height("height").User("user").ToHtml(), new YandexWidgetsCreator().Video(x => x.Id("id").Width("width").Height("height").User("user")));
  }
}