using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexSharePanelWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexSharePanelWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Services(IYandexSharePanelWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Services_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Services(null));
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Services(new YandexSharePanelWidget(), null));

      new YandexSharePanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Services(new string[] { }), widget));
        Assert.False(widget.Field("services").To<IEnumerable<string>>().Any());
      });
      new YandexSharePanelWidget().With(widget => Assert.True(widget.Services(new[] { "first", "second" }).Field("services").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" })));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Language(IYandexSharePanelWidget, CultureInfo)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Language(new YandexSharePanelWidget(), null));

      new YandexSharePanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Language(CultureInfo.CurrentCulture), widget));
        Assert.True(widget.Field("language").To<string>() == CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Layout(IYandexSharePanelWidget, YandexSharePanelLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Layout(null, YandexSharePanelLayout.Button));

      new YandexSharePanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Layout(YandexSharePanelLayout.Button), widget));
        Assert.True(widget.Field("layout").To<string>() == "button");
      });
      new YandexSharePanelWidget().With(widget => Assert.True(widget.Layout(YandexSharePanelLayout.Icon).Field("layout").To<string>() == "icon"));
      new YandexSharePanelWidget().With(widget => Assert.True(widget.Layout(YandexSharePanelLayout.Link).Field("layout").To<string>() == "link"));
      new YandexSharePanelWidget().With(widget => Assert.True(widget.Layout(YandexSharePanelLayout.None).Field("layout").To<string>() == "none"));
    }
  }
}