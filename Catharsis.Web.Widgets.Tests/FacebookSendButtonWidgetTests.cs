using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookSendButtonWidget"/>.</para>
  /// </summary>
  public sealed class FacebookSendButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="FacebookSendButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("kids"));
      Assert.Null(widget.Field("trackLabel"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Url(string.Empty));

      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Width(string.Empty));

      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Height(string.Empty));

      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().ColorScheme(string.Empty));

      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.True(widget.Field("colorScheme").To<string>() == "colorScheme");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Kids"/> method.</para>
    /// </summary>
    [Fact]
    public void Kids_Method()
    {
      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("kids"));
      Assert.True(ReferenceEquals(widget.Kids(), widget));
      Assert.True(widget.Field("kids").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.TrackLabel(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackLabel_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().TrackLabel(null));
      Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().TrackLabel(string.Empty));

      var widget = new FacebookSendButtonWidget();
      Assert.Null(widget.Field("c"));
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.True(widget.Field("trackLabel").To<string>() == "trackLabel");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Write(null));

      Assert.Equal(@"<div class=""fb-send""></div>", new StringWriter().With(writer => new FacebookSendButtonWidget().Write(writer)).ToString());
      Assert.Equal(@"<div class=""fb-send"" data-colorscheme=""dark"" data-height=""height"" data-href=""url"" data-kid-directed-site=""true"" data-ref=""trackLabel"" data-width=""width""></div>", new StringWriter().With(writer => new FacebookSendButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).Kids().Width("width").Height("height").TrackLabel("trackLabel").Write(writer)).ToString());
    }
  }
}