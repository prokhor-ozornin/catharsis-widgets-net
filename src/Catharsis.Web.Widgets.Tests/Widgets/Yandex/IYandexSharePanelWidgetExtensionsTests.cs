using System;
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

      new YandexSharePanelWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Services(new string[] { }), widget));
        Assert.False(widget.Services().Any());
      });
      new YandexSharePanelWidget().Do(widget => Assert.True(widget.Services(new[] { "first", "second" }).Services().SequenceEqual(new[] { "first", "second" })));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Language(IYandexSharePanelWidget, CultureInfo)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Language(new YandexSharePanelWidget(), null));

      new YandexSharePanelWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Language(CultureInfo.CurrentCulture), widget));
        Assert.Equal(CultureInfo.CurrentCulture.TwoLetterISOLanguageName, widget.Language());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Layout(IYandexSharePanelWidget, YandexSharePanelLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexSharePanelWidgetExtensions.Layout(null, YandexSharePanelLayout.Button));

      new YandexSharePanelWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Layout(YandexSharePanelLayout.Button), widget));
        Assert.Equal("button", widget.Layout());
      });
      new YandexSharePanelWidget().Do(widget => Assert.Equal("icon", widget.Layout(YandexSharePanelLayout.Icon).Layout()));
      new YandexSharePanelWidget().Do(widget => Assert.Equal("link", widget.Layout(YandexSharePanelLayout.Link).Layout()));
      new YandexSharePanelWidget().Do(widget => Assert.Equal("none", widget.Layout(YandexSharePanelLayout.None).Layout()));
    }
  }
}