using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestProfileWidget"/>.</para>
  /// </summary>
  public sealed class PinterestProfileWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="PinterestProfileWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new PinterestProfileWidget();
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("imageWidth"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestProfileWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestProfileWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new PinterestProfileWidget().Account(string.Empty));

      var widget = new PinterestProfileWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestProfileWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestProfileWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new PinterestProfileWidget().Height(string.Empty));

      var widget = new PinterestProfileWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestProfileWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestProfileWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new PinterestProfileWidget().Width(string.Empty));

      var widget = new PinterestProfileWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestProfileWidget.ImageWidth(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ImageWidth_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestProfileWidget().ImageWidth(null));
      Assert.Throws<ArgumentException>(() => new PinterestProfileWidget().ImageWidth(string.Empty));

      var widget = new PinterestProfileWidget();
      Assert.Null(widget.Field("imageWidth"));
      Assert.True(ReferenceEquals(widget.ImageWidth("imageWidth"), widget));
      Assert.Equal("imageWidth", widget.Field("imageWidth").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestProfileWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new PinterestProfileWidget().ToString());
      Assert.Equal(@"<a data-pin-do=""embedUser"" href=""http://www.pinterest.com/account""></a>", new PinterestProfileWidget().Account("account").ToString());
      Assert.Equal(@"<a data-pin-board-width=""width"" data-pin-do=""embedUser"" data-pin-scale-height=""height"" data-pin-scale-width=""imageWidth"" href=""http://www.pinterest.com/account""></a>", new PinterestProfileWidget().Account("account").Width("width").Height("height").ImageWidth("imageWidth").ToString());
    }
  }
}