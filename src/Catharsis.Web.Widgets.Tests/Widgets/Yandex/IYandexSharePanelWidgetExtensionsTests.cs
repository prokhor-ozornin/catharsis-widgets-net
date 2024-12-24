using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexSharePanelWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexSharePanelWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Services(IYandexSharePanelWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Services_Method()
  {
    AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Services(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Services(new YandexSharePanelWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("services");

    new YandexSharePanelWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Services(Array.Empty<string>()), widget));
      Assert.False(widget.Services().Any());
    });
    new YandexSharePanelWidget().With(widget => Assert.True(widget.Services(["first", "second"]).Services().SequenceEqual(new[] { "first", "second" })));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Language(IYandexSharePanelWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Language(new YandexSharePanelWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");

    new YandexSharePanelWidget().With(widget =>
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
    AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new YandexSharePanelWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Layout(YandexSharePanelLayout.Button), widget));
      Assert.Equal("button", widget.Layout());
    });
    new YandexSharePanelWidget().With(widget => Assert.Equal("icon", widget.Layout(YandexSharePanelLayout.Icon).Layout()));
    new YandexSharePanelWidget().With(widget => Assert.Equal("link", widget.Layout(YandexSharePanelLayout.Link).Layout()));
    new YandexSharePanelWidget().With(widget => Assert.Equal("none", widget.Layout(YandexSharePanelLayout.None).Layout()));
  }
}