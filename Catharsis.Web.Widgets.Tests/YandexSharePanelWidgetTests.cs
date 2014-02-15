using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexSharePanelWidget"/>.</para>
  /// </summary>
  public sealed class YandexSharePanelWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="YandexSharePanelWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexSharePanelWidget();
      Assert.Null(widget.Field("language"));
      Assert.True(widget.Field("layout").To<string>() == YandexSharePanelLayout.Button.ToString().ToLowerInvariant());
      Assert.True(widget.Field("services").To<IEnumerable<string>>().SequenceEqual(new [] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Language(string.Empty));

      var widget = new YandexSharePanelWidget();
      Assert.Null(widget.Field("language"));
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.True(widget.Field("language").To<string>() == "language");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Services(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Services_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Services(null));

      var widget = new YandexSharePanelWidget();
      Assert.True(widget.Field("services").To<IEnumerable<string>>().SequenceEqual(new[] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" }));
      Assert.True(ReferenceEquals(widget.Services(new[] { "first", "second" }), widget));
      Assert.True(widget.Field("services").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Layout(string.Empty));

      var widget = new YandexSharePanelWidget();
      Assert.True(widget.Field("layout").To<string>() == YandexSharePanelLayout.Button.ToString().ToLowerInvariant());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.ToString()"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexSharePanelWidget().Write(writer)).ToString() == @"<div class=""yashare-auto-init"" data-yashareL10n=""{0}"" data-yashareQuickServices=""yaru,vkontakte,facebook,twitter,odnoklassniki,moimir,lj,friendfeed,moikrug,gplus,pinterest,surfingbird"" data-yashareType=""button""></div>".FormatValue(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName));
      Assert.True(new StringWriter().With(writer => new YandexSharePanelWidget().Services("yaru").Layout(YandexSharePanelLayout.Link).Language("ru").Write(writer)).ToString() == @"<div class=""yashare-auto-init"" data-yashareL10n=""ru"" data-yashareQuickServices=""yaru"" data-yashareType=""link""></div>");
    }
  }
}