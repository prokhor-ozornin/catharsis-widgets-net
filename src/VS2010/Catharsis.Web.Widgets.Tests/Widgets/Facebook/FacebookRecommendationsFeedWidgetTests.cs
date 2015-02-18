using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FacebookRecommendationsFeedWidget"/>.</para>
  /// </summary>
  public sealed class FacebookRecommendationsFeedWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="FacebookRecommendationsFeedWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.Domain());
      Assert.Null(widget.AppId());
      Assert.False(widget.Actions().Any());
      Assert.Null(widget.Width());
      Assert.Null(widget.Height());
      Assert.Null(widget.ColorScheme());
      Assert.Null(widget.Header());
      Assert.Null(widget.LinkTarget());
      Assert.Null(widget.MaxAge());
      Assert.Null(widget.TrackLabel());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().Domain(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.Domain());
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Domain());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.AppId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void AppId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().AppId(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().AppId(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.AppId());
      Assert.True(ReferenceEquals(widget.AppId("appId"), widget));
      Assert.Equal("appId", widget.AppId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().Actions(null));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.False(widget.Actions().Any());
      Assert.True(ReferenceEquals(widget.Actions(new[] { "first", "second" }), widget));
      Assert.True(widget.Actions().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().Width(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().Height(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().ColorScheme(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Header(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.Header());
      Assert.True(ReferenceEquals(widget.Header(true), widget));
      Assert.True(widget.Header().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.LinkTarget(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void LinkTarget_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().LinkTarget(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().LinkTarget(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.LinkTarget());
      Assert.True(ReferenceEquals(widget.LinkTarget("linkTarget"), widget));
      Assert.Equal("linkTarget", widget.LinkTarget());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.MaxAge(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void MaxAge_Method()
    {
      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.MaxAge());
      Assert.True(ReferenceEquals(widget.MaxAge(1), widget));
      Assert.Equal(1, widget.MaxAge().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.TrackLabel(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackLabel_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new FacebookRecommendationsFeedWidget().TrackLabel(null));
      Assert.Throws<ArgumentException>(() => new FacebookRecommendationsFeedWidget().TrackLabel(string.Empty));

      var widget = new FacebookRecommendationsFeedWidget();
      Assert.Null(widget.TrackLabel());
      Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
      Assert.Equal("trackLabel", widget.TrackLabel());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""fb-recommendations""></div>", new FacebookRecommendationsFeedWidget().ToString());
      Assert.Equal(@"<div class=""fb-recommendations"" data-action=""actions"" data-app-id=""appId"" data-colorscheme=""dark"" data-header=""true"" data-height=""height"" data-linktarget=""linkTarget"" data-max-age=""1"" data-ref=""trackLabel"" data-site=""domain"" data-width=""width""></div>", new FacebookRecommendationsFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).TrackLabel("trackLabel").ToString());
    }
  }
}