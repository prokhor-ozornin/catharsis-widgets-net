using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestPinWidget"/>.</para>
  /// </summary>
  public sealed class PinterestPinWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="PinterestPinWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new PinterestPinWidget();
      Assert.Null(widget.Field("id"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestPinWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new PinterestPinWidget().Id(string.Empty));

      var widget = new PinterestPinWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestPinWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new PinterestPinWidget().ToString());
      Assert.Equal(@"<a data-pin-do=""embedPin"" href=""http://www.pinterest.com/pin/id""></a>", new PinterestPinWidget().Id("id").ToString());
    }
  }
}