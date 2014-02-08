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

      Assert.True(new GoogleHtmlHelper().Analytics(x => { }) == new GoogleHtmlHelper().Analytics().ToHtmlString());
      Assert.True(new GoogleHtmlHelper().Analytics(x => x.Account("account").Domain("domain")) == new GoogleHtmlHelper().Analytics().Account("account").Domain("domain").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGoogleHtmlHelperExtensions.PlusOne(IGoogleHtmlHelper, Action{IGooglePlusOneButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void PlusOne_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGoogleHtmlHelperExtensions.PlusOne(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new GoogleHtmlHelper().PlusOne(null));

      Assert.True(new GoogleHtmlHelper().PlusOne(x => { }) == new GoogleHtmlHelper().PlusOne().ToHtmlString());
      Assert.True(new GoogleHtmlHelper().PlusOne(x => x.Url("url")) == new GoogleHtmlHelper().PlusOne().Url("url").ToHtmlString());
    }
  }
}