using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IShare42HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IShare42HtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IShare42HtmlHelperExtensions.Panel(IShare42HtmlHelper, Action{IShare42PanelWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Panel_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IShare42HtmlHelperExtensions.Panel(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new Share42HtmlHelper().Panel(null));

      Assert.True(new Share42HtmlHelper().Panel(x => { }) == new Share42HtmlHelper().Panel().ToHtmlString());
      Assert.True(new Share42HtmlHelper().Panel(x => x.Direction(Share42PanelDirection.Horizontal)) == new Share42HtmlHelper().Panel().Direction(Share42PanelDirection.Horizontal).ToHtmlString());
    }
  }
}