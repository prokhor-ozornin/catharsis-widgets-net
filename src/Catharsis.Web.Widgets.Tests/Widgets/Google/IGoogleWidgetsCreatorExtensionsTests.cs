using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IGoogleWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IGoogleWidgetsCreatorExtensionsTests : UnitTest
{
  private readonly IGoogleWidgetsCreator widgets = Widgets.Web.Google();

  /// <summary>
  ///   <para>Performs testing of <see cref="IGoogleWidgetsCreatorExtensions.Analytics(IGoogleWidgetsCreator, Action{IGoogleAnalyticsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Analytics_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IGoogleWidgetsCreatorExtensions.Analytics(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => widgets.Analytics(null));

    Assert.Equal(widgets.Analytics().ToHtml(), new GoogleWidgetsCreator().Analytics(_ => { }));
    Assert.Equal(widgets.Analytics().Account("account").Domain("domain").ToHtml(), new GoogleWidgetsCreator().Analytics(x => x.Account("account").Domain("domain")));
  }

  /*/// <summary>
  ///   <para>Performs testing of <see cref="IGoogleWidgetsCreatorExtensions.Map(IGoogleWidgetsCreator, Action{IGoogleMapWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Map_Method()
  {
    throw new NotImplementedException();
  }*/

  /// <summary>
  ///   <para>Performs testing of <see cref="IGoogleWidgetsCreatorExtensions.PlusOneButton(IGoogleWidgetsCreator, Action{IGooglePlusOneButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void PlusOneButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IGoogleWidgetsCreatorExtensions.PlusOneButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => widgets.PlusOneButton(null));

    Assert.Equal(widgets.PlusOneButton().ToHtml(), new GoogleWidgetsCreator().PlusOneButton(_ => { }));
    Assert.Equal(widgets.PlusOneButton().Url("url").ToHtml(), new GoogleWidgetsCreator().PlusOneButton(x => x.Url("url")));
  }
}