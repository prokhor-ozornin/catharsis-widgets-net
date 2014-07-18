using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IGoogleHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IGoogleHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IGoogleHtmlHelperExtensions.Analytics(IGoogleHtmlHelper, Action{IGoogleAnalyticsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Analytics_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGoogleHtmlHelperExtensions.Analytics(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new GoogleHtmlHelper().Analytics(null));

      Assert.Equal(new GoogleHtmlHelper().Analytics().ToHtmlString(), new GoogleHtmlHelper().Analytics(x => { }));
      Assert.Equal(new GoogleHtmlHelper().Analytics().Account("account").Domain("domain").ToHtmlString(), new GoogleHtmlHelper().Analytics(x => x.Account("account").Domain("domain")));
    }

    /*/// <summary>
    ///   <para>Performs testing of <see cref="IGoogleHtmlHelperExtensions.Map(IGoogleHtmlHelper, Action{IGoogleMapWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Map_Method()
    {
      throw new NotImplementedException();
    }*/

    /// <summary>
    ///   <para>Performs testing of <see cref="IGoogleHtmlHelperExtensions.PlusOneButton(IGoogleHtmlHelper, Action{IGooglePlusOneButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void PlusOneButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGoogleHtmlHelperExtensions.PlusOneButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new GoogleHtmlHelper().PlusOneButton(null));

      Assert.Equal(new GoogleHtmlHelper().PlusOneButton().ToHtmlString(), new GoogleHtmlHelper().PlusOneButton(x => { }));
      Assert.Equal(new GoogleHtmlHelper().PlusOneButton().Url("url").ToHtmlString(), new GoogleHtmlHelper().PlusOneButton(x => x.Url("url")));
    }
  }
}