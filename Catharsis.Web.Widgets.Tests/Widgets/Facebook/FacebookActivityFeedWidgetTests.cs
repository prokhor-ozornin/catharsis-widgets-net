using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookActivityFeedWidget"/>.</para>
  /// </summary>
  public sealed class FacebookActivityFeedWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookActivityFeedWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookActivityFeedWidget();
      Assert.False(widget.Field("actions").To<IEnumerable<string>>().Any());
      Assert.Null(widget.Field("appId"));
      Assert.Null(widget.Field("colorScheme"));
      Assert.Null(widget.Field("domain"));
      Assert.Null(widget.Field("header"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("linkTarget"));
      Assert.Null(widget.Field("maxAge"));
      Assert.Null(widget.Field("recommendations"));
      Assert.Null(widget.Field("trackLabel"));
      Assert.Null(widget.Field("width"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Actions(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Actions(null));

      var widget = new FacebookActivityFeedWidget();
      Assert.False(widget.Field("actions").To<IEnumerable<string>>().Any());
      Assert.True(ReferenceEquals(widget.Actions(new[] { "first", "second" }), widget));
      Assert.True(widget.Field("actions").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.AppId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void AppId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().AppId(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().AppId(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("appId"));
      Assert.True(ReferenceEquals(widget.AppId("appId"), widget));
      Assert.Equal("appId", widget.Field("appId").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().ColorScheme(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Domain(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("domain"));
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Field("domain").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Header(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("header"));
      Assert.True(ReferenceEquals(widget.Header(), widget));
      Assert.True(widget.Field("header").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Height(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.LinkTarget(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void LinkTarget_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().LinkTarget(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().LinkTarget(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("linkTarget"));
      Assert.True(ReferenceEquals(widget.LinkTarget("linkTarget"), widget));
      Assert.Equal("linkTarget", widget.Field("linkTarget").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.MaxAge(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void MaxAge_Method()
    {
      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("maxAge"));
      Assert.True(ReferenceEquals(widget.MaxAge(1), widget));
      Assert.Equal(1, widget.Field("maxAge").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Recommendations(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Recommendations_Method()
    {
      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("recommendations"));
      Assert.True(ReferenceEquals(widget.Recommendations(), widget));
      Assert.True(widget.Field("recommendations").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.TrackLabel(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackLabel_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().TrackLabel(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().TrackLabel(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("trackLabel"));
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.Equal("trackLabel", widget.Field("trackLabel").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Width(string.Empty));

      var widget = new FacebookActivityFeedWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""fb-activity""></div>", new FacebookActivityFeedWidget().ToString());
      Assert.Equal(@"<div class=""fb-activity"" data-action=""actions"" data-app-id=""appId"" data-colorscheme=""dark"" data-header=""true"" data-height=""height"" data-linktarget=""linkTarget"" data-max-age=""1"" data-recommendations=""true"" data-ref=""trackLabel"" data-site=""domain"" data-width=""width""></div>", new FacebookActivityFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header().LinkTarget("linkTarget").MaxAge(1).Recommendations().TrackLabel("trackLabel").ToString());
    }
  }
}