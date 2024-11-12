using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookFacepileWidget"/>.</para>
  /// </summary>
  public sealed class FacebookFacepileWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookFacepileWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookFacepileWidget();
      Assert.False(widget.Actions().Any());
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Height());
      Assert.Null(widget.MaxRows());
      Assert.Null(widget.PhotoSize());
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Actions(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Actions(null));

      var widget = new FacebookFacepileWidget();
      Assert.False(widget.Actions().Any());
      Assert.True(ReferenceEquals(widget.Actions(new[] { "first", "second" }), widget));
      Assert.True(widget.Actions().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().ColorScheme(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().Height(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.MaxRows(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void MaxRows_Method()
    {
      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.MaxRows());
      Assert.True(ReferenceEquals(widget.MaxRows(1), widget));
      Assert.Equal(1, widget.MaxRows().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.PhotoSize(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PhotoSize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().PhotoSize(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().PhotoSize(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.PhotoSize());
      Assert.True(ReferenceEquals(widget.PhotoSize("photoSize"), widget));
      Assert.Equal("photoSize", widget.PhotoSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().Url(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().Width(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""fb-facepile""></div>", new FacebookFacepileWidget().ToString());
      Assert.Equal(@"<div class=""fb-facepile"" data-action=""actions"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-max-rows=""10"" data-size=""large"" data-width=""width""></div>", new FacebookFacepileWidget().Url("url").Actions("actions").PhotoSize(FacebookFacepilePhotoSize.Large).Width("width").Height("height").MaxRows(10).ColorScheme(FacebookColorScheme.Dark).ToString());
    }
  }
}