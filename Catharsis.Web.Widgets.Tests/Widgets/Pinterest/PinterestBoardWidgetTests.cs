using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PinterestBoardWidget"/>.</para>
  /// </summary>
  public sealed class PinterestBoardWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="PinterestBoardWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("image"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Account(string.Empty));

      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Height(string.Empty));

      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Width(string.Empty));

      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Id(string.Empty));

      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.Image(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Image(null));
      Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Image(string.Empty));

      var widget = new PinterestBoardWidget();
      Assert.Null(widget.Field("image"));
      Assert.True(ReferenceEquals(widget.Image("image"), widget));
      Assert.Equal("image", widget.Field("image").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PinterestBoardWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new PinterestBoardWidget().ToString());
      Assert.Equal(string.Empty, new PinterestBoardWidget().Account("account").ToString());
      Assert.Equal(string.Empty, new PinterestBoardWidget().Id("id").ToString());
      Assert.Equal(@"<a data-pin-do=""embedBoard"" href=""http://www.pinterest.com/account/id""></a>", new PinterestBoardWidget().Account("account").Id("id").ToString());
      Assert.Equal(@"<a data-pin-board-width=""width"" data-pin-do=""embedBoard"" data-pin-scale-height=""height"" data-pin-scale-width=""image"" href=""http://www.pinterest.com/account/id""></a>", new PinterestBoardWidget().Account("account").Id("id").Width("width").Height("height").Image("image").ToString());
    }
  }
}