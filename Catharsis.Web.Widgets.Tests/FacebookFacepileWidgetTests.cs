using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;
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
    ///   <seealso cref="FacebookFacepileWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.Field("url"));
      Assert.False(widget.Field("actions").To<IEnumerable<string>>().Any());
      Assert.Null(widget.Field("size"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("maxRows"));
      Assert.Null(widget.Field("colorScheme"));
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
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Actions(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Actions(null));

      var widget = new FacebookFacepileWidget();
      Assert.False(widget.Field("actions").To<IEnumerable<string>>().Any());
      Assert.True(ReferenceEquals(widget.Actions(new [] { "first", "second" }), widget));
      Assert.True(widget.Field("actions").To<IEnumerable<string>>().SequenceEqual(new [] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new FacebookFacepileWidget().Size(string.Empty));

      var widget = new FacebookFacepileWidget();
      Assert.Null(widget.Field("size"));
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Field("size").To<string>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookFacepileWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookFacepileWidget().Write(null));

      Assert.Equal(@"<div class=""fb-facepile""></div>", new StringWriter().With(writer => new FacebookFacepileWidget().Write(writer)).ToString());
      Assert.Equal(@"<div class=""fb-facepile"" data-action=""actions"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-max-rows=""10"" data-size=""large"" data-width=""width""></div>", new StringWriter().With(writer => new FacebookFacepileWidget().Url("url").Actions("actions").Size(FacebookFacepileSize.Large).Width("width").Height("height").MaxRows(10).ColorScheme(FacebookColorScheme.Dark).Write(writer)).ToString());
    }
  }
}